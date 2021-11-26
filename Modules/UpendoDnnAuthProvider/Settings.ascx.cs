namespace Upendo.Modules.UpendoDnnAuthenticationProvider
{
    using System;

    using DotNetNuke.Services.Authentication;
    using DotNetNuke.Services.Exceptions;
    using Upendo.Modules.UpendoDnnAuthenticationProvider.Components;

    public partial class Settings : AuthenticationSettingsBase
    {
        protected string AuthSystemApplicationName
        {
            get { return "UpendoDnn"; }
        }

        public override void UpdateSettings()
        {
            if (this.SettingsEditor.IsValid && this.SettingsEditor.IsDirty)
            {
                var config = (AuthenticationConfig)this.SettingsEditor.DataSource;
                AuthenticationConfig.UpdateConfig(config);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                AuthConfigBase config = AuthConfigBase.GetConfig(AuthSystemApplicationName, this.PortalId);
                this.SettingsEditor.DataSource = config;
                this.SettingsEditor.DataBind();
            }
            catch (Exception exc)
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }
    }
}