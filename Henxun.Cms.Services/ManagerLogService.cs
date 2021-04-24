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
*│　描    述：操作日志                                                    
*│　作    者：                                             
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2021-03-06 12:15:45                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Henxun.Cms.Services                                  
*│　类    名： ManagerLogService                                    
*└──────────────────────────────────────────────────────────────┘
*/
using Henxun.Cms.IRepository;
using Henxun.Cms.IServices;
using Henxun.Cms.ViewModels;
using System.Threading.Tasks;

namespace Henxun.Cms.Services
{
    public class ManagerLogService: IManagerLogService
    {
        private readonly IManagerLogRepository _repository;

        public ManagerLogService(IManagerLogRepository repository)
        {
            _repository = repository;
        }

        public async Task<TableDataModel> LoadDataAsync(ManagerLogRequestModel model)
        {
            string condition = "where 1=1";
            if (!string.IsNullOrEmpty(model.Key))
            {
                condition += $" and remark like @Key";
            }
            var para = new
            {
                Key = $"%{model.Key}%"
            };
            var list = await _repository.GetListPagedAsync(model.Page, model.Limit, condition, "Id desc", para);
            return new TableDataModel
            {
                count = await _repository.RecordCountAsync(condition, para),
                data = list,
            };
        }
    }
}