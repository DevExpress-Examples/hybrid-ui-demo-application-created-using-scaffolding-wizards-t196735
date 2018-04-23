﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExpress.HybridApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
    <ImageUri>Resources/Employees/All.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Salaried</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Salaried#</FilterCriteria>
    <ImageUri>Resources/Employees/Salaried.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Commission</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Commission#</FilterCriteria>
    <ImageUri>Resources/Employees/Commission.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Contract</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Contract#</FilterCriteria>
    <ImageUri>Resources/Employees/Probation.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Terminated</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Terminated#</FilterCriteria>
    <ImageUri>Resources/Employees/Terminated.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>On Leave</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,OnLeave#</FilterCriteria>
    <ImageUri>Resources/Employees/OnLeave.png</ImageUri>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList EmployeesStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["EmployeesStaticFilters"]));
            }
            set {
                this["EmployeesStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All Customers</Name>
  </FilterInfo>
  <FilterInfo>
    <Name>My Account</Name>
    <FilterCriteria>[AddressState] = 'CA'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>John's Account</Name>
    <FilterCriteria>[AddressState] = 'WA'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Top Stores</Name>
    <FilterCriteria>[AnnualRevenue] &gt;= 90000000000.0m</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList CustomersCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["CustomersCustomFilters"]));
            }
            set {
                this["CustomersCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>HD Video player</Name>
    <FilterCriteria>Contains([Name], 'HD') And Category = 'VideoPlayers'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>50inch Plasma</Name>
    <FilterCriteria>Contains([Name], '50') And Category = 'Televisions'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>21inch Monitor</Name>
    <FilterCriteria>Contains([Name], '21') And Category = 'Monitors'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Remote Control</Name>
    <FilterCriteria>Contains([Name], 'remote') And Category = 'Automation'</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList ProductsCustomFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductsCustomFilters"]));
            }
            set {
                this["ProductsCustomFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
    <ImageUri>Resources/Products/All.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Video Players</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,VideoPlayers#</FilterCriteria>
    <ImageUri>Resources/Products/VideoPlayers.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Automation</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Automation#</FilterCriteria>
    <ImageUri>Resources/Products/Automation.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Monitors</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Monitors#</FilterCriteria>
    <ImageUri>Resources/Products/Monitors.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Projectors</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Projectors#</FilterCriteria>
    <ImageUri>Resources/Products/Projectors.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Televisions</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Televisions#</FilterCriteria>
    <ImageUri>Resources/Products/TVs.png</ImageUri>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList ProductsStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductsStaticFilters"]));
            }
            set {
                this["ProductsStaticFilters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfFilterInfo xmlns:xsi=\"http://www" +
            ".w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n" +
            "  <FilterInfo>\r\n    <Name>All Tasks</Name>\r\n    <ImageUri>Resources/Tasks/InProg" +
            "ress.png</ImageUri>\r\n  </FilterInfo>\r\n  <FilterInfo>\r\n    <Name>In Progress</Nam" +
            "e>\r\n    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,In" +
            "Progress#</FilterCriteria>\r\n    <ImageUri>Resources/Tasks/InProgress.png</ImageU" +
            "ri>\r\n  </FilterInfo>\r\n  <FilterInfo>\r\n    <Name>Not Started</Name>\r\n    <FilterC" +
            "riteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,NotStarted#</Filte" +
            "rCriteria>\r\n    <ImageUri>Resources/Tasks/NotStarted.png</ImageUri>\r\n  </FilterI" +
            "nfo>\r\n  <FilterInfo>\r\n    <Name>Deferred</Name>\r\n    <FilterCriteria>[Status] = " +
            "##Enum#DevExpress.DevAV.EmployeeTaskStatus,Deferred#</FilterCriteria>\r\n    <Imag" +
            "eUri>Resources/Tasks/Deferred.png</ImageUri>\r\n  </FilterInfo>\r\n  <FilterInfo>\r\n " +
            "   <Name>Completed</Name>\r\n    <FilterCriteria>[Status] = ##Enum#DevExpress.DevA" +
            "V.EmployeeTaskStatus,Completed#</FilterCriteria>\r\n    <ImageUri>Resources/Tasks/" +
            "Completed.png</ImageUri>\r\n  </FilterInfo>\r\n  <FilterInfo>\r\n    <Name>High Priori" +
            "ty</Name>\r\n    <FilterCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTask" +
            "Priority,High#</FilterCriteria>\r\n    <ImageUri>Resources/Tasks/HighPriority.png<" +
            "/ImageUri>\r\n  </FilterInfo>\r\n  <FilterInfo>\r\n    <Name>Urgent</Name>\r\n    <Filte" +
            "rCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTaskPriority,Urgent#</Fil" +
            "terCriteria>\r\n    <ImageUri>Resources/Tasks/Urgent.png</ImageUri>\r\n  </FilterInf" +
            "o>\r\n</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList TasksStaticFilters {
            get {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["TasksStaticFilters"]));
            }
            set {
                this["TasksStaticFilters"] = value;
            }
        }
    }
}
