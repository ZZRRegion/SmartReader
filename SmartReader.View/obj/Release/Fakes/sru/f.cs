// <assemblyHash>ef449b63</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=14.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias mqttf;
extern alias sru;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("SmartReader.Util", false)]
[assembly: global::System.Reflection.AssemblyCompany("Microsoft")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("SmartReader.Util")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace SmartReader.Util.Fakes
{
    /// <summary>Shim type of SmartReader.Util.JSHelper</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(sru::SmartReader.Util.JSHelper))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of JSHelper")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimJSHelper
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<sru::SmartReader.Util.JSHelper>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimJSHelper()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimJSHelper(sru::SmartReader.Util.JSHelper instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::SmartReader.Util.Fakes.ShimJSHelper.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::SmartReader.Util.Fakes.ShimJSHelper.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(sru::SmartReader.Util.JSHelper), value);
            }
        }

        /// <summary>Sets the shim of JSHelper.JSHelper()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<sru::SmartReader.Util.JSHelper> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(sru::SmartReader.Util.JSHelper), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of JSHelper.ExecuteScript(String expression, String code)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string, string, string> ExecuteScriptStringString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("ExecuteScript", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(sru::SmartReader.Util.JSHelper), 
                     "ExecuteScript", typeof(string), new global::System.Type[]{typeof(string), typeof(string)});
            }
        }
    }
}
namespace SmartReader.Util.Fakes
{
    /// <summary>Stub type of SmartReader.Util.JSHelper</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(sru::SmartReader.Util.JSHelper))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of JSHelper")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubJSHelper
      : sru::SmartReader.Util.JSHelper
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<sru::SmartReader.Util.JSHelper>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubJSHelper()
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubJSHelper</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
