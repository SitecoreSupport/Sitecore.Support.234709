using Sitecore.ExperienceForms.Mvc.Pipelines.RenderForm;
using Sitecore.Mvc.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ExperienceForms.Mvc.Pipelines.RenderForm
{
  public class SetLanguage : MvcPipelineProcessor<RenderFormEventArgs>
  {
    public override void Process(RenderFormEventArgs args)
    {
      if (args.QueryString != null&& args.FormBuilderContext.FormBuilderMode==Sitecore.ExperienceForms.FormBuilderMode.Load)
      {
        args.QueryString["sc_lang"]= Sitecore.Context.Language.Name;
      }
    }
  }
}