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
*│　描    述：                                                    
*│　作    者：                                               
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2021-03-06 12:15:46                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: Henxun.Cms.Models                                  
*│　类    名：NLog                                     
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Henxun.Cms.Models
{
	/// <summary>
	///  
	/// 2021-03-06 12:15:46
	/// 
	/// </summary>
	public partial class NLog
	{
		/// <summary>
		///  
		/// </summary>
		[Key]
		public Int32 Id {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(50)]
		public String Application {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? Logged {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(50)]
		public String Level {get;set;}

		/// <summary>
		///  
		/// </summary>
		public String Message {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(250)]
		public String Logger {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(512)]
		public String Callsite {get;set;}

		/// <summary>
		///  
		/// </summary>
		public String Exception {get;set;}


	}
}
