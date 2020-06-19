import { override } from '@microsoft/decorators';
import { Log } from '@microsoft/sp-core-library';
import {
  BaseApplicationCustomizer
} from '@microsoft/sp-application-base';
import { Dialog } from '@microsoft/sp-dialog';
import { AppInsights } from 'applicationinsights-js';

import * as strings from 'AppInsightsApplicationCustomizerStrings';

const LOG_SOURCE: string = 'AppInsightsApplicationCustomizer';

/**
 * If your command set uses the ClientSideComponentProperties JSON input,
 * it will be deserialized into the BaseExtension.properties object.
 * You can define an interface to describe it.
 */
export interface IAppInsightsApplicationCustomizerProperties {
  // This is an example; replace with your own property
  instrumentationKey: string;
}

/** A Custom Action which can be run during execution of a Client Side Application */
export default class AppInsightsApplicationCustomizer
  extends BaseApplicationCustomizer<IAppInsightsApplicationCustomizerProperties> {

  @override
  public onInit(): Promise<void> {

    let instrumentationKeyProp = this.properties.instrumentationKey;

    Log.info(LOG_SOURCE, `Initialized ${strings.Title} V2`);

    if (instrumentationKeyProp) {
      /*eval(`var appInsights=window.appInsights||function(a){
        function b(a){c[a]=function(){var b=arguments;c.queue.push(function(){c[a].apply(c,b)})}}var c={config:a},d=document,e=window;setTimeout(function(){var b=d.createElement("script");b.src=a.url||"https://az416426.vo.msecnd.net/scripts/a/ai.0.js",d.getElementsByTagName("script")[0].parentNode.appendChild(b)});try{c.cookie=d.cookie}catch(a){}c.queue=[];for(var f=["Event","Exception","Metric","PageView","Trace","Dependency"];f.length;)b("track"+f.pop());if(b("setAuthenticatedUserContext"),b("clearAuthenticatedUserContext"),b("startTrackEvent"),b("stopTrackEvent"),b("startTrackPage"),b("stopTrackPage"),b("flush"),!a.disableExceptionTracking){f="onerror",b("_"+f);var g=e[f];e[f]=function(a,b,d,e,h){var i=g&&g(a,b,d,e,h);return!0!==i&&c["_"+f](a,b,d,e,h),i}}return c
        }({
            instrumentationKey:"${instrumentationKey}"
        });
      
      window.appInsights=appInsights,appInsights.queue&&0===appInsights.queue.length&&appInsights.trackPageView();`);*/
      
      /* Call downloadAndSetup to download full ApplicationInsights script from CDN and initialize it with instrumentation key */
      AppInsights.downloadAndSetup({ instrumentationKey: instrumentationKeyProp });

      AppInsights.setAuthenticatedUserContext(this.context.pageContext.user.email);

      AppInsights.trackPageView();

      // track event
      AppInsights.trackEvent('AppInsightsApplicationCustomizer', <any>{
        site_id: this.context.pageContext.site.id,
        web_id: this.context.pageContext.web.id,
        web_title: this.context.pageContext.web.title,
        web_desc: this.context.pageContext.web.description,
        pag_Url: this.context.pageContext.legacyPageContext.serverRequestPath
      });

      console.log('App Insight configured');

      Log.info(LOG_SOURCE, "App Insights registered successfully!!!");
    }
    else {
      Log.info(LOG_SOURCE, "Instrumentation Key is missing ");
    }

    Log.info(LOG_SOURCE, "Finished App Insights Application Customizer");

    return Promise.resolve();
  }
}
