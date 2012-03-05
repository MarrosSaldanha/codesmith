﻿//------------------------------------------------------------------------------
//
// Copyright (c) 2002-2012 CodeSmith Tools, LLC.  All rights reserved.
// 
// The terms of use for this software are contained in the file
// named sourcelicense.txt, which can be found in the root of this distribution.
// By using this software in any fashion, you are agreeing to be bound by the
// terms of this license.
// 
// You must not remove this notice, or any other, from this software.
//
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

using CodeSmith.Engine;
using CodeSmith.SchemaHelper;
using Configuration = CodeSmith.SchemaHelper.Configuration;

namespace Generator.CSLA
{
    public class CSLABaseTemplate : CodeTemplate
    {
        #region Constructor(s)

        public CSLABaseTemplate()
        {
            ResolveTargetLanguage();
            Configuration.Instance.NamingProperty.AssociationSuffix = AssociationSuffix.None;
        }

        #endregion

        #region Public Properties

        [Browsable(false)]
        public string TemplateVersion
        {
            get
            {
                var fileName = GetType().Assembly.Location;
                if (fileName != null)
                {
                    return FileVersionInfo.GetVersionInfo(fileName).FileVersion;
                }

                return "4.3.0.0";
            }
        }

        [Browsable(false)]
        public string CSLAVersion
        {
            get
            {
                return IsLatestCSLA ? "4.3.10" : "3.8.4";
            }
        }

        [Browsable(false)]
        public virtual bool IsLatestCSLA
        {
            get
            {
                return Configuration.Instance.FrameworkVersion == FrameworkVersion.v40;
            }
        }

        [Browsable(false)]
        public string CodeSmithVersion
        {
            get
            {
                return CodeSmith.Engine.Configuration.Instance.ConfigurationVersion;
            }
        }

        [Browsable(false)]
        public string VersionInfo
        {
            get
            {
                return String.Format("CodeSmith: v{0}, CSLA Templates: v{1}, CSLA Framework: v{2}", CodeSmithVersion, TemplateVersion, CSLAVersion);
            }
        }

        #endregion

        #region Private Method(s)

        private void ResolveTargetLanguage()
        {
            if (CodeTemplateInfo != null)
            {
                if (CodeTemplateInfo.TargetLanguage.ToUpper() == "VB")
                {
                    Configuration.Instance.TargetLanguage = Language.VB;
                }
                else
                {
                    Configuration.Instance.TargetLanguage = Language.CSharp;
                }
            }
        }

        #endregion

        #region Public Method(s)

        public virtual void RegisterReferences()
        {
            RegisterReference(!IsLatestCSLA
                                  ? Path.GetFullPath(Path.Combine(CodeTemplateInfo.DirectoryName, @"..\..\Common\Csla\3.8\Client\Csla.dll"))
                                  : Path.GetFullPath(Path.Combine(CodeTemplateInfo.DirectoryName, @"..\..\Common\Csla\4.3\Client\Csla.dll")));

            RegisterReference("System.Configuration");
        }

        #endregion

        #region Render Helpers

        public void RenderHelper<T>(T template) where T : EntityCodeTemplate
        {
            RenderHelper(template, false);
        }

        public void RenderHelper<T>(T template, bool renderOptionalContent) where T : EntityCodeTemplate
        {
            CopyPropertiesTo(template, true, new List<string>() { "SourceTable", "SourceView", "SourceCommand" });
            template.RenderOptionalContent = renderOptionalContent;
            template.Render(this.Response);
        }

        public void RenderHelper<T>(T template, IEntity entity) where T : EntityCodeTemplate
        {
            RenderHelper(template, entity, false);
        }

        public void RenderHelper<T>(T template, IEntity entity, bool renderOptionalContent) where T : EntityCodeTemplate
        {
            this.CopyPropertiesTo(template, true, new List<string>() { "SourceTable", "SourceView", "SourceCommand" });
            template.Entity = entity;
            template.RenderOptionalContent = renderOptionalContent;
            template.Render(this.Response);
        }

        #endregion
    }
}
