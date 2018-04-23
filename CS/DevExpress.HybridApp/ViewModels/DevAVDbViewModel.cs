﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using DevExpress.DevAV.Localization;
using DevExpress.DevAV.DevAVDbDataModel;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the DevAVDb data model.
    /// </summary>
    public partial class DevAVDbViewModel : DocumentsViewModel<DevAVDbModuleDescription, IDevAVDbUnitOfWork> {
        const string MyWorldGroup = "My World";
        const string OperationsGroup = "Operations";
        INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        /// <summary>
        /// Creates a new instance of DevAVDbViewModel as a POCO view model.
        /// </summary>
        public static DevAVDbViewModel Create() {
            return ViewModelSource.Create(() => new DevAVDbViewModel());
        }

        static DevAVDbViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<DevAVDbMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the DevAVDbViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DevAVDbViewModel type without the POCO proxy factory.
        /// </summary>
        protected DevAVDbViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override DevAVDbModuleDescription[] CreateModules() {
            var modules = new DevAVDbModuleDescription[] {
                new DevAVDbModuleDescription("Tasks", "EmployeeTaskCollectionView", MyWorldGroup, FiltersSettings.GetTasksFilterTree(this)),
                new DevAVDbModuleDescription("Employees", "EmployeeCollectionView", MyWorldGroup, FiltersSettings.GetEmployeesFilterTree(this)),
                new DevAVDbModuleDescription("Products", "ProductCollectionView", OperationsGroup, FiltersSettings.GetProductsFilterTree(this)),
                new DevAVDbModuleDescription("Customers", "CustomerCollectionView", OperationsGroup, FiltersSettings.GetCustomersFilterTree(this)),
                new DevAVDbModuleDescription("Sales", "OrderCollectionView", OperationsGroup, FiltersSettings.GetSalesFilterTree(this)),
                new DevAVDbModuleDescription("Opportunities", "QuoteCollectionView", OperationsGroup, FiltersSettings.GetOpportunitiesFilterTree(this))
            };
            foreach(var module in modules) {
                DevAVDbModuleDescription moduleRef = module;
                //_ Action that shows module if is not visible at the moment when filter is selected
                module.FilterTreeViewModel.NavigateAction = () => Show(moduleRef);
            }
            return modules;
        }

        public override DevAVDbModuleDescription DefaultModule
        {
            get { return Modules[1]; }
        }

        protected override void OnActiveModuleChanged(DevAVDbModuleDescription oldModule) {
            if(ActiveModule != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
            if(ActiveModule != null && ActiveModule.FilterTreeViewModel != null)
                ActiveModule.FilterTreeViewModel.SetViewModel(DocumentManagerService.ActiveDocument.Content);
        }
    }

    public partial class DevAVDbModuleDescription : ModuleDescription<DevAVDbModuleDescription> {
        public DevAVDbModuleDescription(string title, string documentType, string group, IFilterTreeViewModel filterTreeViewModel = null)
               : base(title, documentType, group, null) {
            FilterTreeViewModel = filterTreeViewModel;
        }
        public IFilterTreeViewModel FilterTreeViewModel { get; private set; }
    }
}