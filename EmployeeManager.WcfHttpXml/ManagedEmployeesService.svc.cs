using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeManager.WcfHttpXml
{
    // メモ: [リファクター] メニューの [名前の変更] コマンドを使用すると、コード、svc、および config ファイルで同時にクラス名 "ManagedEmployeesService" を変更できます。
    // 注意: このサービスをテストするために WCF テスト クライアントを起動するには、ソリューション エクスプローラーで ManagedEmployeesService.svc または ManagedEmployeesService.svc.cs を選択し、デバッグを開始してください。
    public class ManagedEmployeesService : IManagedEmployeesService
    {
        public void DoWork()
        {
        }

        public IList<ManagedEmployee> GetManagedEmployees()
        {
            return ManagedEmployee.ManagedEmployees.Value;
        }
    }
}
