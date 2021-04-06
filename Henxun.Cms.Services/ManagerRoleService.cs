////////////////////////////////////////////////////////////////////
//                          _ooOoo_                               //
//                         o8888888o                              //
//                         88" . "88                              //
//                         (| ^_^ |)                              //
//                         O\  =  /O                              //
//                      ____/`---'\____                           //
//                    .'  \\|     |//  `.                         //
//                   /  \\|||  :  |||//  \                        //
//                  /  _||||| -:- |||||-  \                       //
//                  |   | \\\  -  /// |   |                       //
//                  | \_|  ''\---/''  |   |                       //
//                  \  .-\__  `-`  ___/-. /                       //
//                ___`. .'  /--.--\  `. . ___                     //
//              ."" '<  `.___\_<|>_/___.'  >'"".                  //
//            | | :  `- \`.;`\ _ /`;.`/ - ` : | |                 //
//            \  \ `-.   \_ __\ /__ _/   .-` /  /                 //
//      ========`-.____`-.___\_____/___.-`____.-'========         //
//                           `=---='                              //
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^        //
//                   佛祖保佑       永不宕机     永无BUG          //
////////////////////////////////////////////////////////////////////



using AutoMapper;
using Henxun.Cms.IRepository;
using Henxun.Cms.IServices;
using Henxun.Cms.Models;
using Henxun.Cms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理员角色                                                    
*│　作    者：                                             
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2021-03-06 12:15:45                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Henxun.Cms.Services                                  
*│　类    名： ManagerRoleService                                    
*└──────────────────────────────────────────────────────────────┘
*/
namespace Henxun.Cms.Services
{
    public class ManagerRoleService : IManagerRoleService
    {
        private readonly IManagerRoleRepository _repository;
        private readonly IMapper _mapper;

        public ManagerRoleService(IManagerRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        /// <summary>
        /// 新增或者修改服务
        /// </summary>
        /// <param name="item">新增或者修改试图实体</param>
        /// <returns>结果实体</returns>
        public BaseResult AddOrModify(ManagerRoleAddOrModifyModel item)
        {
            var result = new BaseResult();
            ManagerRole managerRole;
            if (item.Id == 0)
            {
                //TODO ADD
                managerRole = _mapper.Map<ManagerRole>(item);
                managerRole.AddManagerId = 1;
                managerRole.IsDelete = false;
                managerRole.AddTime = DateTime.Now;
                if (_repository.InsertByTrans(managerRole) > 0)
                {
                    result.ResultCode = ResultCodeAddMsgKeys.CommonObjectSuccessCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonObjectSuccessMsg;
                }
                else
                {
                    result.ResultCode = ResultCodeAddMsgKeys.CommonExceptionCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonExceptionMsg;
                }
            }
            else
            {
                //TODO Modify
                managerRole = _repository.Get(item.Id);
                if (managerRole != null)
                {
                    _mapper.Map(item, managerRole);
                    managerRole.ModifyManagerId = 1;
                    managerRole.ModifyTime = DateTime.Now;
                    if (_repository.UpdateByTrans(managerRole) > 0)
                    {
                        result.ResultCode = ResultCodeAddMsgKeys.CommonObjectSuccessCode;
                        result.ResultMsg = ResultCodeAddMsgKeys.CommonObjectSuccessMsg;
                    }
                    else
                    {
                        result.ResultCode = ResultCodeAddMsgKeys.CommonExceptionCode;
                        result.ResultMsg = ResultCodeAddMsgKeys.CommonExceptionMsg;
                    }
                }
                else
                {
                    result.ResultCode = ResultCodeAddMsgKeys.CommonFailNoDataCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonFailNoDataMsg;
                }
            }
            return result;

        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="roleId">角色主键id</param>
        /// <returns>结果实体</returns>
        public BaseResult DeleteIds(int[] roleId)
        {
            var result = new BaseResult();
            if (roleId.Count() == 0)
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;

            }
            else
            {
                var count = _repository.DeleteLogical(roleId);
                if (count > 0)
                {
                    //成功
                    result.ResultCode = ResultCodeAddMsgKeys.CommonObjectSuccessCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonObjectSuccessMsg;
                }
                else
                {
                    //失败
                    result.ResultCode = ResultCodeAddMsgKeys.CommonExceptionCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonExceptionMsg;
                }
            }
            return result;
        }

        public List<ManagerRole> GetListByCondition(ManagerRoleRequestModel model)
        {
            string conditions = "where IsDelete=0 ";//未删除的
            if (!string.IsNullOrWhiteSpace(model.Key))
            {
                conditions += $"and RoleName like '%@Key%'";
            }
            return _repository.GetList(conditions, new
            {
                Key = model.Key,
            }).ToList();
        }



        /// <summary>
        /// 根据查询条件获取数据
        /// </summary>
        /// <param name="model">查询实体</param>
        /// <returns></returns>
        public TableDataModel LoadData(ManagerRoleRequestModel model)
        {
            string conditions = "where IsDelete=0 ";//未删除的
            if (!string.IsNullOrWhiteSpace(model.Key))
            {
                conditions += $"and RoleName like '%@Key%'";
            }
            return new TableDataModel
            {
                count = _repository.RecordCount(conditions),
                data = _repository.GetListPaged(model.Page, model.Limit, conditions, "Id desc", new
                {
                    Key = model.Key,
                }),
            };
        }

        public List<MenuNavView> GetMenusByRoleId(int roleId)
        {
            var menuList = _repository.GetMenusByRoleId(roleId);
            if (menuList?.Count() == 0)
            {
                return new List<MenuNavView>();
            }
            var menuNavViewList = new List<MenuNavView>();
            menuList.ForEach(x =>
            {
                var navView = _mapper.Map<MenuNavView>(x);
                menuNavViewList.Add(navView);
            });
            return menuNavViewList;
        }

        public async Task<BaseResult> DeleteIdsAsync(int[] roleId)
        {
            var result = new BaseResult();
            if (roleId.Count() == 0)
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;

            }
            else
            {
                var count = await _repository.DeleteLogicalAsync(roleId);
                if (count > 0)
                {
                    //成功
                    result.ResultCode = ResultCodeAddMsgKeys.CommonObjectSuccessCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonObjectSuccessMsg;
                }
                else
                {
                    //失败
                    result.ResultCode = ResultCodeAddMsgKeys.CommonExceptionCode;
                    result.ResultMsg = ResultCodeAddMsgKeys.CommonExceptionMsg;
                }
            }
            return result;
        }

        public ManagerRoleListModel Get(int id)
        {
            var managerRole = _repository.Get(id);
            
            return _mapper.Map<ManagerRoleListModel>(managerRole);
        }
    }
}