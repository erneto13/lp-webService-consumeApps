﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lp_webService_consumeApps.consumirApps {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="consumirApps.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombreApp del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CPUz", ReplyAction="*")]
        lp_webService_consumeApps.consumirApps.CPUzResponse CPUz(lp_webService_consumeApps.consumirApps.CPUzRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CPUz", ReplyAction="*")]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.CPUzResponse> CPUzAsync(lp_webService_consumeApps.consumirApps.CPUzRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombreApp del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WinRAR", ReplyAction="*")]
        lp_webService_consumeApps.consumirApps.WinRARResponse WinRAR(lp_webService_consumeApps.consumirApps.WinRARRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WinRAR", ReplyAction="*")]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.WinRARResponse> WinRARAsync(lp_webService_consumeApps.consumirApps.WinRARRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombreApp del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NotepadPlusPlus", ReplyAction="*")]
        lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponse NotepadPlusPlus(lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NotepadPlusPlus", ReplyAction="*")]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponse> NotepadPlusPlusAsync(lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombreApp del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/JFLAP", ReplyAction="*")]
        lp_webService_consumeApps.consumirApps.JFLAPResponse JFLAP(lp_webService_consumeApps.consumirApps.JFLAPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/JFLAP", ReplyAction="*")]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.JFLAPResponse> JFLAPAsync(lp_webService_consumeApps.consumirApps.JFLAPRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombreApp del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Brave", ReplyAction="*")]
        lp_webService_consumeApps.consumirApps.BraveResponse Brave(lp_webService_consumeApps.consumirApps.BraveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Brave", ReplyAction="*")]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.BraveResponse> BraveAsync(lp_webService_consumeApps.consumirApps.BraveRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CPUzRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CPUz", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.CPUzRequestBody Body;
        
        public CPUzRequest() {
        }
        
        public CPUzRequest(lp_webService_consumeApps.consumirApps.CPUzRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CPUzRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombreApp;
        
        public CPUzRequestBody() {
        }
        
        public CPUzRequestBody(string nombreApp) {
            this.nombreApp = nombreApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CPUzResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CPUzResponse", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.CPUzResponseBody Body;
        
        public CPUzResponse() {
        }
        
        public CPUzResponse(lp_webService_consumeApps.consumirApps.CPUzResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CPUzResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CPUzResult;
        
        public CPUzResponseBody() {
        }
        
        public CPUzResponseBody(string CPUzResult) {
            this.CPUzResult = CPUzResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WinRARRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WinRAR", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.WinRARRequestBody Body;
        
        public WinRARRequest() {
        }
        
        public WinRARRequest(lp_webService_consumeApps.consumirApps.WinRARRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WinRARRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombreApp;
        
        public WinRARRequestBody() {
        }
        
        public WinRARRequestBody(string nombreApp) {
            this.nombreApp = nombreApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WinRARResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WinRARResponse", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.WinRARResponseBody Body;
        
        public WinRARResponse() {
        }
        
        public WinRARResponse(lp_webService_consumeApps.consumirApps.WinRARResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WinRARResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WinRARResult;
        
        public WinRARResponseBody() {
        }
        
        public WinRARResponseBody(string WinRARResult) {
            this.WinRARResult = WinRARResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotepadPlusPlusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NotepadPlusPlus", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequestBody Body;
        
        public NotepadPlusPlusRequest() {
        }
        
        public NotepadPlusPlusRequest(lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NotepadPlusPlusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombreApp;
        
        public NotepadPlusPlusRequestBody() {
        }
        
        public NotepadPlusPlusRequestBody(string nombreApp) {
            this.nombreApp = nombreApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotepadPlusPlusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NotepadPlusPlusResponse", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponseBody Body;
        
        public NotepadPlusPlusResponse() {
        }
        
        public NotepadPlusPlusResponse(lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NotepadPlusPlusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NotepadPlusPlusResult;
        
        public NotepadPlusPlusResponseBody() {
        }
        
        public NotepadPlusPlusResponseBody(string NotepadPlusPlusResult) {
            this.NotepadPlusPlusResult = NotepadPlusPlusResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class JFLAPRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="JFLAP", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.JFLAPRequestBody Body;
        
        public JFLAPRequest() {
        }
        
        public JFLAPRequest(lp_webService_consumeApps.consumirApps.JFLAPRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class JFLAPRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombreApp;
        
        public JFLAPRequestBody() {
        }
        
        public JFLAPRequestBody(string nombreApp) {
            this.nombreApp = nombreApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class JFLAPResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="JFLAPResponse", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.JFLAPResponseBody Body;
        
        public JFLAPResponse() {
        }
        
        public JFLAPResponse(lp_webService_consumeApps.consumirApps.JFLAPResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class JFLAPResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string JFLAPResult;
        
        public JFLAPResponseBody() {
        }
        
        public JFLAPResponseBody(string JFLAPResult) {
            this.JFLAPResult = JFLAPResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BraveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Brave", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.BraveRequestBody Body;
        
        public BraveRequest() {
        }
        
        public BraveRequest(lp_webService_consumeApps.consumirApps.BraveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BraveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombreApp;
        
        public BraveRequestBody() {
        }
        
        public BraveRequestBody(string nombreApp) {
            this.nombreApp = nombreApp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BraveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BraveResponse", Namespace="http://tempuri.org/", Order=0)]
        public lp_webService_consumeApps.consumirApps.BraveResponseBody Body;
        
        public BraveResponse() {
        }
        
        public BraveResponse(lp_webService_consumeApps.consumirApps.BraveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BraveResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BraveResult;
        
        public BraveResponseBody() {
        }
        
        public BraveResponseBody(string BraveResult) {
            this.BraveResult = BraveResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : lp_webService_consumeApps.consumirApps.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<lp_webService_consumeApps.consumirApps.WebService1Soap>, lp_webService_consumeApps.consumirApps.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lp_webService_consumeApps.consumirApps.CPUzResponse lp_webService_consumeApps.consumirApps.WebService1Soap.CPUz(lp_webService_consumeApps.consumirApps.CPUzRequest request) {
            return base.Channel.CPUz(request);
        }
        
        public string CPUz(string nombreApp) {
            lp_webService_consumeApps.consumirApps.CPUzRequest inValue = new lp_webService_consumeApps.consumirApps.CPUzRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.CPUzRequestBody();
            inValue.Body.nombreApp = nombreApp;
            lp_webService_consumeApps.consumirApps.CPUzResponse retVal = ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).CPUz(inValue);
            return retVal.Body.CPUzResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.CPUzResponse> lp_webService_consumeApps.consumirApps.WebService1Soap.CPUzAsync(lp_webService_consumeApps.consumirApps.CPUzRequest request) {
            return base.Channel.CPUzAsync(request);
        }
        
        public System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.CPUzResponse> CPUzAsync(string nombreApp) {
            lp_webService_consumeApps.consumirApps.CPUzRequest inValue = new lp_webService_consumeApps.consumirApps.CPUzRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.CPUzRequestBody();
            inValue.Body.nombreApp = nombreApp;
            return ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).CPUzAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lp_webService_consumeApps.consumirApps.WinRARResponse lp_webService_consumeApps.consumirApps.WebService1Soap.WinRAR(lp_webService_consumeApps.consumirApps.WinRARRequest request) {
            return base.Channel.WinRAR(request);
        }
        
        public string WinRAR(string nombreApp) {
            lp_webService_consumeApps.consumirApps.WinRARRequest inValue = new lp_webService_consumeApps.consumirApps.WinRARRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.WinRARRequestBody();
            inValue.Body.nombreApp = nombreApp;
            lp_webService_consumeApps.consumirApps.WinRARResponse retVal = ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).WinRAR(inValue);
            return retVal.Body.WinRARResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.WinRARResponse> lp_webService_consumeApps.consumirApps.WebService1Soap.WinRARAsync(lp_webService_consumeApps.consumirApps.WinRARRequest request) {
            return base.Channel.WinRARAsync(request);
        }
        
        public System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.WinRARResponse> WinRARAsync(string nombreApp) {
            lp_webService_consumeApps.consumirApps.WinRARRequest inValue = new lp_webService_consumeApps.consumirApps.WinRARRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.WinRARRequestBody();
            inValue.Body.nombreApp = nombreApp;
            return ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).WinRARAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponse lp_webService_consumeApps.consumirApps.WebService1Soap.NotepadPlusPlus(lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest request) {
            return base.Channel.NotepadPlusPlus(request);
        }
        
        public string NotepadPlusPlus(string nombreApp) {
            lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest inValue = new lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequestBody();
            inValue.Body.nombreApp = nombreApp;
            lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponse retVal = ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).NotepadPlusPlus(inValue);
            return retVal.Body.NotepadPlusPlusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponse> lp_webService_consumeApps.consumirApps.WebService1Soap.NotepadPlusPlusAsync(lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest request) {
            return base.Channel.NotepadPlusPlusAsync(request);
        }
        
        public System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.NotepadPlusPlusResponse> NotepadPlusPlusAsync(string nombreApp) {
            lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest inValue = new lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.NotepadPlusPlusRequestBody();
            inValue.Body.nombreApp = nombreApp;
            return ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).NotepadPlusPlusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lp_webService_consumeApps.consumirApps.JFLAPResponse lp_webService_consumeApps.consumirApps.WebService1Soap.JFLAP(lp_webService_consumeApps.consumirApps.JFLAPRequest request) {
            return base.Channel.JFLAP(request);
        }
        
        public string JFLAP(string nombreApp) {
            lp_webService_consumeApps.consumirApps.JFLAPRequest inValue = new lp_webService_consumeApps.consumirApps.JFLAPRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.JFLAPRequestBody();
            inValue.Body.nombreApp = nombreApp;
            lp_webService_consumeApps.consumirApps.JFLAPResponse retVal = ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).JFLAP(inValue);
            return retVal.Body.JFLAPResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.JFLAPResponse> lp_webService_consumeApps.consumirApps.WebService1Soap.JFLAPAsync(lp_webService_consumeApps.consumirApps.JFLAPRequest request) {
            return base.Channel.JFLAPAsync(request);
        }
        
        public System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.JFLAPResponse> JFLAPAsync(string nombreApp) {
            lp_webService_consumeApps.consumirApps.JFLAPRequest inValue = new lp_webService_consumeApps.consumirApps.JFLAPRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.JFLAPRequestBody();
            inValue.Body.nombreApp = nombreApp;
            return ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).JFLAPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lp_webService_consumeApps.consumirApps.BraveResponse lp_webService_consumeApps.consumirApps.WebService1Soap.Brave(lp_webService_consumeApps.consumirApps.BraveRequest request) {
            return base.Channel.Brave(request);
        }
        
        public string Brave(string nombreApp) {
            lp_webService_consumeApps.consumirApps.BraveRequest inValue = new lp_webService_consumeApps.consumirApps.BraveRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.BraveRequestBody();
            inValue.Body.nombreApp = nombreApp;
            lp_webService_consumeApps.consumirApps.BraveResponse retVal = ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).Brave(inValue);
            return retVal.Body.BraveResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.BraveResponse> lp_webService_consumeApps.consumirApps.WebService1Soap.BraveAsync(lp_webService_consumeApps.consumirApps.BraveRequest request) {
            return base.Channel.BraveAsync(request);
        }
        
        public System.Threading.Tasks.Task<lp_webService_consumeApps.consumirApps.BraveResponse> BraveAsync(string nombreApp) {
            lp_webService_consumeApps.consumirApps.BraveRequest inValue = new lp_webService_consumeApps.consumirApps.BraveRequest();
            inValue.Body = new lp_webService_consumeApps.consumirApps.BraveRequestBody();
            inValue.Body.nombreApp = nombreApp;
            return ((lp_webService_consumeApps.consumirApps.WebService1Soap)(this)).BraveAsync(inValue);
        }
    }
}
