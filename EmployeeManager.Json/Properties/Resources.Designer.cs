﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManager.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EmployeeManager.Json.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   [{&quot;BusinessEntityID&quot;:1,&quot;FirstName&quot;:&quot;Ken&quot;,&quot;LastName&quot;:&quot;Sánchez&quot;,&quot;EmailPromotion&quot;:0,&quot;NationalIDNumber&quot;:&quot;295847284&quot;,&quot;LoginID&quot;:&quot;adventure-works\\ken0&quot;,&quot;JobTitle&quot;:&quot;Chief Executive Officer&quot;,&quot;BirthDate&quot;:&quot;1969-01-29T00:00:00&quot;,&quot;MaritalStatus&quot;:&quot;S&quot;,&quot;Gender&quot;:&quot;M&quot;,&quot;HireDate&quot;:&quot;2009-01-14T00:00:00&quot;,&quot;SalariedFlag&quot;:true,&quot;VacationHours&quot;:99,&quot;SickLeaveHours&quot;:69,&quot;CurrentFlag&quot;:true,&quot;Rate&quot;:125.5000,&quot;PayFrequency&quot;:2,&quot;GroupName&quot;:&quot;Executive General and Administration&quot;,&quot;DepartmentName&quot;:&quot;Executive&quot;,&quot;StartDate&quot;:&quot;2009-01-14T00:00:00&quot;,&quot;Shi [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ManagedEmployees {
            get {
                return ResourceManager.GetString("ManagedEmployees", resourceCulture);
            }
        }
    }
}
