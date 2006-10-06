﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.573.
// 
namespace com.google.api.adwords.v6 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CampaignServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v6")]
    public class CampaignServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public email emailValue;
        
        public clientEmail clientEmailValue;
        
        public password passwordValue;
        
        public useragent useragentValue;
        
        public token tokenValue;
        
        public applicationToken applicationTokenValue;
        
        public developerToken developerTokenValue;
        
        public responseTime responseTimeValue;
        
        public operations operationsValue;
        
        public units unitsValue;
        
        /// <remarks/>
        public CampaignServiceService() {
            this.Url = "https://adwords.google.com/api/adwords/v6/CampaignService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignReturn")]
        public Campaign getCampaign(int id) {
            object[] results = this.Invoke("getCampaign", new object[] {
                        id});
            return ((Campaign)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCampaign(int id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaign", new object[] {
                        id}, callback, asyncState);
        }
        
        /// <remarks/>
        public Campaign EndgetCampaign(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignListReturn")]
        public Campaign[] getCampaignList([System.Xml.Serialization.XmlElementAttribute("ids")] int[] ids) {
            object[] results = this.Invoke("getCampaignList", new object[] {
                        ids});
            return ((Campaign[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCampaignList(int[] ids, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaignList", new object[] {
                        ids}, callback, asyncState);
        }
        
        /// <remarks/>
        public Campaign[] EndgetCampaignList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllAdWordsCampaignsReturn")]
        public Campaign[] getAllAdWordsCampaigns(int dummy) {
            object[] results = this.Invoke("getAllAdWordsCampaigns", new object[] {
                        dummy});
            return ((Campaign[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAllAdWordsCampaigns(int dummy, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAllAdWordsCampaigns", new object[] {
                        dummy}, callback, asyncState);
        }
        
        /// <remarks/>
        public Campaign[] EndgetAllAdWordsCampaigns(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addCampaignReturn")]
        public Campaign addCampaign(Campaign campaign) {
            object[] results = this.Invoke("addCampaign", new object[] {
                        campaign});
            return ((Campaign)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginaddCampaign(Campaign campaign, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addCampaign", new object[] {
                        campaign}, callback, asyncState);
        }
        
        /// <remarks/>
        public Campaign EndaddCampaign(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addCampaignListReturn")]
        public Campaign[] addCampaignList([System.Xml.Serialization.XmlElementAttribute("campaigns")] Campaign[] campaigns) {
            object[] results = this.Invoke("addCampaignList", new object[] {
                        campaigns});
            return ((Campaign[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginaddCampaignList(Campaign[] campaigns, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addCampaignList", new object[] {
                        campaigns}, callback, asyncState);
        }
        
        /// <remarks/>
        public Campaign[] EndaddCampaignList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateCampaign(Campaign campaign) {
            this.Invoke("updateCampaign", new object[] {
                        campaign});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginupdateCampaign(Campaign campaign, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateCampaign", new object[] {
                        campaign}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndupdateCampaign(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateCampaignList([System.Xml.Serialization.XmlElementAttribute("campaigns")] Campaign[] campaigns) {
            this.Invoke("updateCampaignList", new object[] {
                        campaigns});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginupdateCampaignList(Campaign[] campaigns, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateCampaignList", new object[] {
                        campaigns}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndupdateCampaignList(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getOptimizeAdServingReturn")]
        public bool getOptimizeAdServing(int campaignId) {
            object[] results = this.Invoke("getOptimizeAdServing", new object[] {
                        campaignId});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetOptimizeAdServing(int campaignId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getOptimizeAdServing", new object[] {
                        campaignId}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndgetOptimizeAdServing(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setOptimizeAdServing(int campaignId, bool enable) {
            this.Invoke("setOptimizeAdServing", new object[] {
                        campaignId,
                        enable});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginsetOptimizeAdServing(int campaignId, bool enable, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("setOptimizeAdServing", new object[] {
                        campaignId,
                        enable}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndsetOptimizeAdServing(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignStatsReturn")]
        public StatsRecord[] getCampaignStats([System.Xml.Serialization.XmlElementAttribute("campaignIds")] int[] campaignIds, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime startDay, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime endDay, bool inPST) {
            object[] results = this.Invoke("getCampaignStats", new object[] {
                        campaignIds,
                        startDay,
                        endDay,
                        inPST});
            return ((StatsRecord[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCampaignStats(int[] campaignIds, System.DateTime startDay, System.DateTime endDay, bool inPST, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaignStats", new object[] {
                        campaignIds,
                        startDay,
                        endDay,
                        inPST}, callback, asyncState);
        }
        
        /// <remarks/>
        public StatsRecord[] EndgetCampaignStats(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsRecord[])(results[0]));
        }
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class Campaign {
        
        /// <remarks/>
        public long dailyBudget;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dailyBudgetSpecified;
        
        /// <remarks/>
        public bool enableSeparateContentBids;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime endDay;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDaySpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GeoTarget geoTargeting;
        
        /// <remarks/>
        public int id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("languages")]
        public string[] languageTargeting;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("networkTypes", IsNullable=false)]
        public NetworkType[] networkTargeting;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime startDay;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDaySpecified;
        
        /// <remarks/>
        public CampaignStatus status;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class GeoTarget {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cities", IsNullable=true)]
        public string[] cities;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countries", IsNullable=true)]
        public string[] countries;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metros", IsNullable=true)]
        public string[] metros;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("regions", IsNullable=true)]
        public string[] regions;
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum NetworkType {
        
        /// <remarks/>
        GoogleSearch,
        
        /// <remarks/>
        SearchNetwork,
        
        /// <remarks/>
        ContentNetwork,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum CampaignStatus {
        
        /// <remarks/>
        Active,
        
        /// <remarks/>
        Pending,
        
        /// <remarks/>
        Ended,
        
        /// <remarks/>
        Paused,
        
        /// <remarks/>
        Deleted,
        
        /// <remarks/>
        Suspended,
    }
}