//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace TKOrleansInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EmployeeFactory
    {
        

            public static IEmployee Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return EmployeeReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("TKOrleansInterfaces.IEmployee")]
        internal class EmployeeReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, TKOrleansInterfaces.IEmployee
        {
            

            public static IEmployee Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IEmployee) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IEmployee), (global::Orleans.Runtime.GrainReference gr) => { return new EmployeeReference(gr);}, grainRef, 587671118);
            }
            
            protected internal EmployeeReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal EmployeeReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 587671118;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "TKOrleansInterfaces.IEmployee";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                EmployeeReference input = ((EmployeeReference)(original));
                return ((EmployeeReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                EmployeeReference input = ((EmployeeReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return EmployeeReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return EmployeeMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<int> TKOrleansInterfaces.IEmployee.GetLevel()
            {

                return base.InvokeMethodAsync<System.Int32>(312402437, null );
            }
            
            System.Threading.Tasks.Task TKOrleansInterfaces.IEmployee.Promote(int @newLevel)
            {

                return base.InvokeMethodAsync<object>(-1461035780, new object[] {@newLevel} );
            }
            
            System.Threading.Tasks.Task<TKOrleansInterfaces.IManager> TKOrleansInterfaces.IEmployee.GetManager()
            {

                return base.InvokeMethodAsync<TKOrleansInterfaces.IManager>(940043127, null );
            }
            
            System.Threading.Tasks.Task TKOrleansInterfaces.IEmployee.SetManager(TKOrleansInterfaces.IManager @manager)
            {

                return base.InvokeMethodAsync<object>(-159913581, new object[] {@manager is global::Orleans.Grain ? @manager.AsReference<TKOrleansInterfaces.IManager>() : @manager} );
            }
            
            System.Threading.Tasks.Task TKOrleansInterfaces.IEmployee.Greeting(TKOrleansInterfaces.IEmployee @from, string @message)
            {

                return base.InvokeMethodAsync<object>(-1319124596, new object[] {@from is global::Orleans.Grain ? @from.AsReference<TKOrleansInterfaces.IEmployee>() : @from, @message} );
            }
            
            System.Threading.Tasks.Task TKOrleansInterfaces.IEmployee.Do(string @message)
            {

                return base.InvokeMethodAsync<object>(1860114687, new object[] {@message} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("TKOrleansInterfaces.IEmployee", 587671118)]
    internal class EmployeeMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 587671118;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 587671118:  // IEmployee
                        switch (methodId)
                        {
                            case 312402437: 
                                return ((IEmployee)grain).GetLevel().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1461035780: 
                                return ((IEmployee)grain).Promote((System.Int32)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 940043127: 
                                return ((IEmployee)grain).GetManager().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -159913581: 
                                return ((IEmployee)grain).SetManager((IManager)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -1319124596: 
                                return ((IEmployee)grain).Greeting((IEmployee)arguments[0], (System.String)arguments[1]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 1860114687: 
                                return ((IEmployee)grain).Do((System.String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 587671118:  // IEmployee
                    switch (methodId)
                    {
                        case 312402437:
                            return "GetLevel";
                    case -1461035780:
                            return "Promote";
                    case 940043127:
                            return "GetManager";
                    case -159913581:
                            return "SetManager";
                    case -1319124596:
                            return "Greeting";
                    case 1860114687:
                            return "Do";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class ManagerFactory
    {
        

            public static IManager Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return ManagerReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("TKOrleansInterfaces.IManager")]
        internal class ManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, TKOrleansInterfaces.IManager
        {
            

            public static IManager Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IManager) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IManager), (global::Orleans.Runtime.GrainReference gr) => { return new ManagerReference(gr);}, grainRef, 1530413783);
            }
            
            protected internal ManagerReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal ManagerReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1530413783;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "TKOrleansInterfaces.IManager";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                ManagerReference input = ((ManagerReference)(original));
                return ((ManagerReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                ManagerReference input = ((ManagerReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return ManagerReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return ManagerMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<TKOrleansInterfaces.IEmployee> TKOrleansInterfaces.IManager.AsEmployee()
            {

                return base.InvokeMethodAsync<TKOrleansInterfaces.IEmployee>(-1701259070, null );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.List<TKOrleansInterfaces.IEmployee>> TKOrleansInterfaces.IManager.GetDirectReports()
            {

                return base.InvokeMethodAsync<System.Collections.Generic.List<TKOrleansInterfaces.IEmployee>>(-675836216, null );
            }
            
            System.Threading.Tasks.Task TKOrleansInterfaces.IManager.AddDirectReport(TKOrleansInterfaces.IEmployee @employee)
            {

                return base.InvokeMethodAsync<object>(-1731443267, new object[] {@employee is global::Orleans.Grain ? @employee.AsReference<TKOrleansInterfaces.IEmployee>() : @employee} );
            }
            
            System.Threading.Tasks.Task TKOrleansInterfaces.IManager.Order(string @message)
            {

                return base.InvokeMethodAsync<object>(-459995068, new object[] {@message} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("TKOrleansInterfaces.IManager", 1530413783)]
    internal class ManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1530413783;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1530413783:  // IManager
                        switch (methodId)
                        {
                            case -1701259070: 
                                return ((IManager)grain).AsEmployee().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -675836216: 
                                return ((IManager)grain).GetDirectReports().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            case -1731443267: 
                                return ((IManager)grain).AddDirectReport((IEmployee)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -459995068: 
                                return ((IManager)grain).Order((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1530413783:  // IManager
                    switch (methodId)
                    {
                        case -1701259070:
                            return "AsEmployee";
                    case -675836216:
                            return "GetDirectReports";
                    case -1731443267:
                            return "AddDirectReport";
                    case -459995068:
                            return "Order";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class MyGrain1Factory
    {
        

            public static IMyGrain1 Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return MyGrain1Reference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("TKOrleansInterfaces.IMyGrain1")]
        internal class MyGrain1Reference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, TKOrleansInterfaces.IMyGrain1
        {
            

            public static IMyGrain1 Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IMyGrain1) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IMyGrain1), (global::Orleans.Runtime.GrainReference gr) => { return new MyGrain1Reference(gr);}, grainRef, -974803324);
            }
            
            protected internal MyGrain1Reference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal MyGrain1Reference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -974803324;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "TKOrleansInterfaces.IMyGrain1";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                MyGrain1Reference input = ((MyGrain1Reference)(original));
                return ((MyGrain1Reference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                MyGrain1Reference input = ((MyGrain1Reference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return MyGrain1Reference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return MyGrain1MethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task<string> TKOrleansInterfaces.IMyGrain1.SayHello()
            {

                return base.InvokeMethodAsync<System.String>(-1732333552, null );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("TKOrleansInterfaces.IMyGrain1", -974803324)]
    internal class MyGrain1MethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -974803324;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -974803324:  // IMyGrain1
                        switch (methodId)
                        {
                            case -1732333552: 
                                return ((IMyGrain1)grain).SayHello().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -974803324:  // IMyGrain1
                    switch (methodId)
                    {
                        case -1732333552:
                            return "SayHello";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif