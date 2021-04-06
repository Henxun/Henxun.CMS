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

/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理菜单                                                    
*│　作    者：                                             
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2021-03-06 12:15:46                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Henxun.Cms.Services                                  
*│　类    名： MenuService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using AutoMapper;
using Henxun.Cms.IRepository;
using Henxun.Cms.IServices;
using Henxun.Cms.Models;
using Henxun.Cms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Henxun.Cms.Services
{
    public class MenuService: IMenuService
    {
        private readonly IMenuRepository _repository;
        private readonly IMapper mapper;

        public MenuService(IMenuRepository repository, IMapper mapper)
        {
            _repository = repository;
            this.mapper = mapper;
        }

        public BaseResult AddOrModify(MenuAddOrModifyModel item)
        {
            var result = new BaseResult();
            Menu menu;
            if (item.Id == 0)
            {
                //TODO ADD
                menu = mapper.Map<Menu>(item);
                menu.AddManagerId = 1;
                menu.IsDelete = false;
                menu.AddTime = DateTime.Now;
                if (_repository.Insert(menu) > 0)
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
                menu = _repository.Get(item.Id);
                if (menu != null)
                {
                    mapper.Map(item, menu);
                    menu.ModifyManagerId = 1;
                    menu.ModifyTime = DateTime.Now;
                    if (_repository.Update(menu) > 0)
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

        public async Task<BaseResult> AddOrModifyAsync(MenuAddOrModifyModel item)
        {
            var result = new BaseResult();
            Menu menu;
            if (item.Id == 0)
            {
                //TODO ADD
                menu = mapper.Map<Menu>(item);
                menu.AddManagerId = 1;
                menu.IsDelete = false;
                menu.AddTime = DateTime.Now;
                if (await _repository.InsertAsync(menu) > 0)
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
                menu = await _repository.GetAsync(item.Id);
                if (menu != null)
                {
                    mapper.Map(item, menu);
                    menu.ModifyManagerId = 1;
                    menu.ModifyTime = DateTime.Now;
                    if (await _repository.UpdateAsync(menu) > 0)
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

        public BaseResult Delete(int[] ids)
        {
            var result = new BaseResult();
            if (ids.Count() == 0)
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;

            }
            else
            {
                var count = _repository.DeleteLogical(ids);
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

        public async Task<BaseResult> DeleteAsync(int[] ids)
        {
            var result = new BaseResult();
            if (ids.Count() == 0)
            {
                result.ResultCode = ResultCodeAddMsgKeys.CommonModelStateInvalidCode;
                result.ResultMsg = ResultCodeAddMsgKeys.CommonModelStateInvalidMsg;

            }
            else
            {
                var count = await _repository.DeleteLogicalAsync(ids);
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

        public List<Menu> GetListByCondition(MenuRequestModel model)
        {
            string conditions = "where IsDelete=0 ";//未删除的
            if (!string.IsNullOrWhiteSpace(model.Key))
            {
                conditions += $"and DisplayName like '%@Key%'";
            }
            return _repository.GetList(conditions, new
            {
                Key = model.Key,
            }).ToList();
        }

        public async Task<List<Menu>> GetListByConditionAsync(MenuRequestModel model)
        {
            string conditions = "where IsDelete=0 ";//未删除的
            if (!string.IsNullOrWhiteSpace(model.Key))
            {
                conditions += $"and DisplayName like '%@Key%'";
            }
            var list = await _repository.GetListAsync(conditions, new
            {
                Key = model.Key,
            });
            return list.ToList();
        }

        public TableDataModel LoadData(MenuRequestModel model)
        {
            string conditions = "where IsDelete=0 ";//未删除的
            if (!string.IsNullOrWhiteSpace(model.Key))
            {
                conditions += $"and DisplayName like @Key";
            }
            var para = new
            {
                Key = $"%{model.Key}%"
            };
            return new TableDataModel
            {
                count = _repository.RecordCount(conditions,para),
                data = _repository.GetListPaged(model.Page, model.Limit, conditions, "Id desc", para),
            };
        }

        public async Task<TableDataModel> LoadDataAsync(MenuRequestModel model)
        {
            string conditions = "where IsDelete=0 ";//未删除的
            if (!string.IsNullOrWhiteSpace(model.Key))
            {
                conditions += $"and DisplayName like @Key";
            }
            var para = new
            {
                Key = $"%{model.Key}%"
            };
            var list = (await _repository.GetListPagedAsync(model.Page, model.Limit, conditions, "Id desc", para)).ToList();

            var viewList = new List<MenuListModel>();
            list?.ForEach(m =>
            {
                var item = mapper.Map<MenuListModel>(m);
                viewList.Add(item);
            });
            return new TableDataModel
            {
                count = await _repository.RecordCountAsync(conditions, para),
                data = viewList,
            };
        }
    }
}