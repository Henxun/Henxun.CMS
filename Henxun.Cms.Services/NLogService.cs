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
/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：                                                    
*│　作    者：                                             
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2021-03-06 12:15:46                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Henxun.Cms.Services                                  
*│　类    名： NLogService                                    
*└──────────────────────────────────────────────────────────────┘
*/
namespace Henxun.Cms.Services
{
    public class NLogService: INLogService
    {
        private readonly INLogRepository _repository;

        public NLogService(INLogRepository repository)
        {
            _repository = repository;
        }
    }
}