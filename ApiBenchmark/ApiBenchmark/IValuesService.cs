using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ApiBenchmark.Models;

namespace ApiBenchmark
{
    // メモ: [リファクター] メニューの [名前の変更] コマンドを使用すると、コードと config ファイルの両方で同時にインターフェイス名 "IValuesService" を変更できます。
    [ServiceContract]
    public interface IValuesService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Get")]
        IEnumerable<string> Get();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetSalesOrderHeaderDetails/{id}")]
        IEnumerable<SalesOrderHeaderDetail> GetSalesOrderHeaderDetails(string id);
    }
}
