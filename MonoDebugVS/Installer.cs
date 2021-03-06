﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicDevices.MonoDebugVS
{
    [RunInstaller(true)]
    public class MonoDebugInstaller : Installer
    {
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            try
            {
                RegistryHelper.SetupRegistry();
            } catch
            {
                
            }

            base.Install(stateSaver);
        }

        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            try
            {
                RegistryHelper.CleanRegistry();
            } catch
            {
                
            }

            base.Uninstall(savedState);
        }
    }
}
