﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tp3._2.WSMeteo {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSMeteo.meteo3ilSoap")]
    public interface meteo3ilSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Notice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Notice();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Notice", ReplyAction="*")]
        System.Threading.Tasks.Task<string> NoticeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Value", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tp3._2.WSMeteo.Get_ValueResponse Get_Value(tp3._2.WSMeteo.Get_ValueRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs de retour.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Value", ReplyAction="*")]
        System.Threading.Tasks.Task<tp3._2.WSMeteo.Get_ValueResponse> Get_ValueAsync(tp3._2.WSMeteo.Get_ValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ValueByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tp3._2.WSMeteo.Get_ValueByDateResponse Get_ValueByDate(tp3._2.WSMeteo.Get_ValueByDateRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs de retour.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ValueByDate", ReplyAction="*")]
        System.Threading.Tasks.Task<tp3._2.WSMeteo.Get_ValueByDateResponse> Get_ValueByDateAsync(tp3._2.WSMeteo.Get_ValueByDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ValueByPeriod", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        tp3._2.WSMeteo.Get_ValueByPeriodResponse Get_ValueByPeriod(tp3._2.WSMeteo.Get_ValueByPeriodRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs de retour.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ValueByPeriod", ReplyAction="*")]
        System.Threading.Tasks.Task<tp3._2.WSMeteo.Get_ValueByPeriodResponse> Get_ValueByPeriodAsync(tp3._2.WSMeteo.Get_ValueByPeriodRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_Value", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int i_NumValue;
        
        public Get_ValueRequest() {
        }
        
        public Get_ValueRequest(int i_NumValue) {
            this.i_NumValue = i_NumValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_ValueResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Get_ValueResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string s_DateValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string s_DescValue;
        
        public Get_ValueResponse() {
        }
        
        public Get_ValueResponse(string Get_ValueResult, string s_DateValue, string s_DescValue) {
            this.Get_ValueResult = Get_ValueResult;
            this.s_DateValue = s_DateValue;
            this.s_DescValue = s_DescValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_ValueByDate", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueByDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int i_NumValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string s_DateValueIn;
        
        public Get_ValueByDateRequest() {
        }
        
        public Get_ValueByDateRequest(int i_NumValue, string s_DateValueIn) {
            this.i_NumValue = i_NumValue;
            this.s_DateValueIn = s_DateValueIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_ValueByDateResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueByDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Get_ValueByDateResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string s_DateValueOut;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string s_DescValue;
        
        public Get_ValueByDateResponse() {
        }
        
        public Get_ValueByDateResponse(string Get_ValueByDateResult, string s_DateValueOut, string s_DescValue) {
            this.Get_ValueByDateResult = Get_ValueByDateResult;
            this.s_DateValueOut = s_DateValueOut;
            this.s_DescValue = s_DescValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_ValueByPeriod", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueByPeriodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int i_NumValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string s_DateValue1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string s_DateValue2;
        
        public Get_ValueByPeriodRequest() {
        }
        
        public Get_ValueByPeriodRequest(int i_NumValue, string s_DateValue1, string s_DateValue2) {
            this.i_NumValue = i_NumValue;
            this.s_DateValue1 = s_DateValue1;
            this.s_DateValue2 = s_DateValue2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_ValueByPeriodResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueByPeriodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataSet Get_ValueByPeriodResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int i_Count;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string s_DescValue;
        
        public Get_ValueByPeriodResponse() {
        }
        
        public Get_ValueByPeriodResponse(System.Data.DataSet Get_ValueByPeriodResult, int i_Count, string s_DescValue) {
            this.Get_ValueByPeriodResult = Get_ValueByPeriodResult;
            this.i_Count = i_Count;
            this.s_DescValue = s_DescValue;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface meteo3ilSoapChannel : tp3._2.WSMeteo.meteo3ilSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class meteo3ilSoapClient : System.ServiceModel.ClientBase<tp3._2.WSMeteo.meteo3ilSoap>, tp3._2.WSMeteo.meteo3ilSoap {
        
        public meteo3ilSoapClient() {
        }
        
        public meteo3ilSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public meteo3ilSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public meteo3ilSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public meteo3ilSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Notice() {
            return base.Channel.Notice();
        }
        
        public System.Threading.Tasks.Task<string> NoticeAsync() {
            return base.Channel.NoticeAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tp3._2.WSMeteo.Get_ValueResponse tp3._2.WSMeteo.meteo3ilSoap.Get_Value(tp3._2.WSMeteo.Get_ValueRequest request) {
            return base.Channel.Get_Value(request);
        }
        
        public string Get_Value(int i_NumValue, out string s_DateValue, out string s_DescValue) {
            tp3._2.WSMeteo.Get_ValueRequest inValue = new tp3._2.WSMeteo.Get_ValueRequest();
            inValue.i_NumValue = i_NumValue;
            tp3._2.WSMeteo.Get_ValueResponse retVal = ((tp3._2.WSMeteo.meteo3ilSoap)(this)).Get_Value(inValue);
            s_DateValue = retVal.s_DateValue;
            s_DescValue = retVal.s_DescValue;
            return retVal.Get_ValueResult;
        }
        
        public System.Threading.Tasks.Task<tp3._2.WSMeteo.Get_ValueResponse> Get_ValueAsync(tp3._2.WSMeteo.Get_ValueRequest request) {
            return base.Channel.Get_ValueAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tp3._2.WSMeteo.Get_ValueByDateResponse tp3._2.WSMeteo.meteo3ilSoap.Get_ValueByDate(tp3._2.WSMeteo.Get_ValueByDateRequest request) {
            return base.Channel.Get_ValueByDate(request);
        }
        
        public string Get_ValueByDate(int i_NumValue, string s_DateValueIn, out string s_DateValueOut, out string s_DescValue) {
            tp3._2.WSMeteo.Get_ValueByDateRequest inValue = new tp3._2.WSMeteo.Get_ValueByDateRequest();
            inValue.i_NumValue = i_NumValue;
            inValue.s_DateValueIn = s_DateValueIn;
            tp3._2.WSMeteo.Get_ValueByDateResponse retVal = ((tp3._2.WSMeteo.meteo3ilSoap)(this)).Get_ValueByDate(inValue);
            s_DateValueOut = retVal.s_DateValueOut;
            s_DescValue = retVal.s_DescValue;
            return retVal.Get_ValueByDateResult;
        }
        
        public System.Threading.Tasks.Task<tp3._2.WSMeteo.Get_ValueByDateResponse> Get_ValueByDateAsync(tp3._2.WSMeteo.Get_ValueByDateRequest request) {
            return base.Channel.Get_ValueByDateAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        tp3._2.WSMeteo.Get_ValueByPeriodResponse tp3._2.WSMeteo.meteo3ilSoap.Get_ValueByPeriod(tp3._2.WSMeteo.Get_ValueByPeriodRequest request) {
            return base.Channel.Get_ValueByPeriod(request);
        }
        
        public System.Data.DataSet Get_ValueByPeriod(int i_NumValue, string s_DateValue1, string s_DateValue2, out int i_Count, out string s_DescValue) {
            tp3._2.WSMeteo.Get_ValueByPeriodRequest inValue = new tp3._2.WSMeteo.Get_ValueByPeriodRequest();
            inValue.i_NumValue = i_NumValue;
            inValue.s_DateValue1 = s_DateValue1;
            inValue.s_DateValue2 = s_DateValue2;
            tp3._2.WSMeteo.Get_ValueByPeriodResponse retVal = ((tp3._2.WSMeteo.meteo3ilSoap)(this)).Get_ValueByPeriod(inValue);
            i_Count = retVal.i_Count;
            s_DescValue = retVal.s_DescValue;
            return retVal.Get_ValueByPeriodResult;
        }
        
        public System.Threading.Tasks.Task<tp3._2.WSMeteo.Get_ValueByPeriodResponse> Get_ValueByPeriodAsync(tp3._2.WSMeteo.Get_ValueByPeriodRequest request) {
            return base.Channel.Get_ValueByPeriodAsync(request);
        }
    }
}
