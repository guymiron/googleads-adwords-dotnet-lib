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
namespace com.google.api.adwords.v7 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CriterionServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v7")]
    public class CriterionServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public email emailValue;
        
        public clientEmail clientEmailValue;
        
        public clientCustomerId clientCustomerIdValue;
        
        public password passwordValue;
        
        public useragent useragentValue;
        
        public token tokenValue;
        
        public applicationToken applicationTokenValue;
        
        public developerToken developerTokenValue;
        
        public responseTime responseTimeValue;
        
        public operations operationsValue;
        
        public units unitsValue;
        
        public requestId requestIdValue;
        
        /// <remarks/>
        public CriterionServiceService() {
            this.Url = "https://adwords.google.com/api/adwords/v7/CriterionService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllCriteriaReturn")]
        public Criterion[] getAllCriteria(int adGroupId) {
            object[] results = this.Invoke("getAllCriteria", new object[] {
                        adGroupId});
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAllCriteria(int adGroupId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAllCriteria", new object[] {
                        adGroupId}, callback, asyncState);
        }
        
        /// <remarks/>
        public Criterion[] EndgetAllCriteria(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCriteriaReturn")]
        public Criterion[] getCriteria(int adGroupId, [System.Xml.Serialization.XmlElementAttribute("criterionIds")] long[] criterionIds) {
            object[] results = this.Invoke("getCriteria", new object[] {
                        adGroupId,
                        criterionIds});
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCriteria(int adGroupId, long[] criterionIds, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCriteria", new object[] {
                        adGroupId,
                        criterionIds}, callback, asyncState);
        }
        
        /// <remarks/>
        public Criterion[] EndgetCriteria(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateCriteria([System.Xml.Serialization.XmlElementAttribute("Criteria")] Criterion[] Criteria) {
            this.Invoke("updateCriteria", new object[] {
                        Criteria});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginupdateCriteria(Criterion[] Criteria, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateCriteria", new object[] {
                        Criteria}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndupdateCriteria(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addCriteriaReturn")]
        public Criterion[] addCriteria([System.Xml.Serialization.XmlElementAttribute("newCriteria")] Criterion[] newCriteria) {
            object[] results = this.Invoke("addCriteria", new object[] {
                        newCriteria});
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginaddCriteria(Criterion[] newCriteria, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addCriteria", new object[] {
                        newCriteria}, callback, asyncState);
        }
        
        /// <remarks/>
        public Criterion[] EndaddCriteria(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void removeCriteria(int adGroupId, [System.Xml.Serialization.XmlElementAttribute("criterionIds")] long[] criterionIds) {
            this.Invoke("removeCriteria", new object[] {
                        adGroupId,
                        criterionIds});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginremoveCriteria(int adGroupId, long[] criterionIds, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("removeCriteria", new object[] {
                        adGroupId,
                        criterionIds}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndremoveCriteria(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCriterionStatsReturn")]
        public StatsRecord[] getCriterionStats(int adGroupId, [System.Xml.Serialization.XmlElementAttribute("criterionIds")] long[] criterionIds, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime startDay, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime endDay, bool inPST) {
            object[] results = this.Invoke("getCriterionStats", new object[] {
                        adGroupId,
                        criterionIds,
                        startDay,
                        endDay,
                        inPST});
            return ((StatsRecord[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCriterionStats(int adGroupId, long[] criterionIds, System.DateTime startDay, System.DateTime endDay, bool inPST, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCriterionStats", new object[] {
                        adGroupId,
                        criterionIds,
                        startDay,
                        endDay,
                        inPST}, callback, asyncState);
        }
        
        /// <remarks/>
        public StatsRecord[] EndgetCriterionStats(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsRecord[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignNegativeCriteriaReturn")]
        public Criterion[] getCampaignNegativeCriteria(int campaignId) {
            object[] results = this.Invoke("getCampaignNegativeCriteria", new object[] {
                        campaignId});
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCampaignNegativeCriteria(int campaignId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaignNegativeCriteria", new object[] {
                        campaignId}, callback, asyncState);
        }
        
        /// <remarks/>
        public Criterion[] EndgetCampaignNegativeCriteria(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Criterion[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setCampaignNegativeCriteria(int campaignId, [System.Xml.Serialization.XmlElementAttribute("criteria")] Criterion[] criteria) {
            this.Invoke("setCampaignNegativeCriteria", new object[] {
                        campaignId,
                        criteria});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginsetCampaignNegativeCriteria(int campaignId, Criterion[] criteria, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("setCampaignNegativeCriteria", new object[] {
                        campaignId,
                        criteria}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndsetCampaignNegativeCriteria(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
  
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Website))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Keyword))]
    public abstract class Criterion {
        
        /// <remarks/>
        public int adGroupId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string criterionType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string destinationUrl;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string exemptionRequest;
        
        /// <remarks/>
        public long id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string language;
        
        /// <remarks/>
        public bool negative;
        
        /// <remarks/>
        public bool paused;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pausedSpecified;
        
        /// <remarks/>
        public CriterionStatus status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public enum CriterionStatus {
        
        /// <remarks/>
        Normal,
        
        /// <remarks/>
        InTrial,
        
        /// <remarks/>
        OnHold,
        
        /// <remarks/>
        Disabled,
        
        /// <remarks/>
        Disapproved,
        
        /// <remarks/>
        Deleted,
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class Website : Criterion {
        
        /// <remarks/>
        public long maxCpm;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxCpmSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string url;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class Keyword : Criterion {
        
        /// <remarks/>
        public long maxCpc;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxCpcSpecified;
        
        /// <remarks/>
        public long minCpc;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minCpcSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string text;
        
        /// <remarks/>
        public KeywordType type;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public enum KeywordType {
        
        /// <remarks/>
        Broad,
        
        /// <remarks/>
        Exact,
        
        /// <remarks/>
        Phrase,
    }
}