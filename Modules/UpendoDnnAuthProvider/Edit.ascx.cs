
using DotNetNuke.Services.Exceptions;
using System;
using Upendo.Modules.UpendoDnnAuthenticationProvider.Components;

namespace Upendo.Modules.UpendoDnnAuthenticationProvider
{
    public partial class Edit : UpendoDnnAuthenticationProviderModuleBase
    {
        #region Event Handlers

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BindData();
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        #endregion

        #region Helper Methods

        private void BindData()
        {
            LocalizeModule();
			
			
        }

        private void LocalizeModule()
        {
            
        }

        #endregion
    }
}