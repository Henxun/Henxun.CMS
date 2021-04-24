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



using Henxun.Cms.IRepository;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：定时任务                                                    
*│　作    者：                                             
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2021-03-06 12:15:46                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Henxun.Cms.Services                                  
*│　类    名： TaskInfoService                                    
*└──────────────────────────────────────────────────────────────┘
*/
namespace Henxun.Cms.Services
{
    public class TaskInfoService: ITaskInfoService
    {
        private readonly ITaskInfoRepository _repository;

        public TaskInfoService(ITaskInfoRepository repository)
        {
            _repository = repository;
        }

        public BaseResult AddOrModify(TaskInfoAddOrModifyModel item)
        {
            throw new System.NotImplementedException();
        }

        public Task<BaseResult> AddOrModifyAsync(TaskInfoAddOrModifyModel item)
        {
            throw new System.NotImplementedException();
        }

        public BaseResult Delete(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public Task<BaseResult> DeleteAsync(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public List<TaskInfo> GetListByCondition(TaskRequestModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<TaskInfo>> GetListByConditionAsync(TaskInfoAddOrModifyModel model)
        {
            throw new System.NotImplementedException();
        }

        public TableDataModel LoadData(TaskRequestModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TableDataModel> LoadDataAsync(TaskRequestModel model)
        {
            string condition = "";

            if (!string.IsNullOrEmpty(model.Key))
            {
                condition += "where Name like @Key";
            }
            return new TableDataModel
            {
                count = await _repository.RecordCountAsync(condition, new { Key = $"%{model.Key}%" }),
                data = await _repository.GetListPagedAsync(model.Page, model.Limit, condition, "Id Desc", new { Key = $"%{model.Key}%" })
            };
        }
    }
}