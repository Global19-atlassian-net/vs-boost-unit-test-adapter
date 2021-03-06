// (C) Copyright ETAS 2015.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE_1_0.txt or copy at
// http://www.boost.org/LICENSE_1_0.txt)

// This file has been modified by Microsoft on 8/2017.

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "JobManagement.JobObjectInfoType")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "JobManagement.Job.#CreateJobObject(System.IntPtr,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "JobManagement.Job.#SetInformationJobObject(System.IntPtr,JobManagement.JobObjectInfoType,System.IntPtr,System.UInt32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "JobManagement.Job.#SetInformationJobObject(System.IntPtr,JobManagement.JobObjectInfoType,System.IntPtr,System.UInt32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1414:MarkBooleanPInvokeArgumentsWithMarshalAs", Scope = "member", Target = "JobManagement.Job.#AssignProcessToJobObject(System.IntPtr,System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "JobManagement.Job.#AssignProcessToJobObject(System.IntPtr,System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Scope = "member", Target = "JobManagement.Job.#CloseHandle(System.IntPtr)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "JobManagement.Job.#handle")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "JobManagement.Job.#.ctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "JobManagement.Job.#.ctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2216:DisposableTypesShouldDeclareFinalizer", Scope = "member", Target = "JobManagement.Job.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "JobManagement.Job.#AddProcess(System.Diagnostics.Process)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "BoostTestAdapter.Utility.ExecutionContext.ProcessExecutionContextArgs.#EnvironmentVariables")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "BoostTestAdapter.Discoverers")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "BoostTestAdapter.Utility.ExecutionContext")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "BoostTestAdapter.Utility.VisualStudio")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "JobManagement")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.BoostTestExecutor.#RunTests(System.Collections.Generic.IEnumerable`1<System.String>,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunContext,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IFrameworkHandle)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.BoostTestExecutor.#RunBoostTests(System.Collections.Generic.IEnumerable`1<BoostTestAdapter.Utility.TestRun>,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunContext,Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IFrameworkHandle)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "BoostTestAdapter.Boost.Results.BoostTestResultOutputBase.#.ctor(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XML", Scope = "type", Target = "BoostTestAdapter.Boost.Results.BoostTestResultXMLOutput")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "BoostTestAdapter.Boost.Results.LogEntryTypes.LogEntryException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.Boost.Runner.BoostTestRunnerBase.#KillProcess(System.Diagnostics.Process,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "HRF", Scope = "member", Target = "BoostTestAdapter.Boost.Runner.ListContentFormat.#HRF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DOT", Scope = "member", Target = "BoostTestAdapter.Boost.Runner.ListContentFormat.#DOT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "DOT", Scope = "type", Target = "BoostTestAdapter.Boost.Test.TestFrameworkDOTDeserialiser")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Deserialiser", Scope = "type", Target = "BoostTestAdapter.Boost.Test.TestFrameworkDOTDeserialiser")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Deserialise", Scope = "member", Target = "BoostTestAdapter.Boost.Test.TestFrameworkDOTDeserialiser.#Deserialise(System.IO.Stream)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Deserialise", Scope = "member", Target = "BoostTestAdapter.Boost.Test.TestFrameworkDOTDeserialiser.#Deserialise(System.IO.Stream,BoostTestAdapter.Boost.Test.ITestVisitor)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "BoostTestAdapter.Boost.Test.TestFrameworkDOTDeserialiser+BoostTestFrameworkVisitor.#VisitNode_stmt(Antlr.DOT.DOTParser+Node_stmtContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "BoostTestAdapter.Boost.Test.TestFrameworkDOTDeserialiser+BoostTestFrameworkVisitor.#VisitEdge_stmt(Antlr.DOT.DOTParser+Edge_stmtContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Std", Scope = "member", Target = "BoostTestAdapter.Settings.BoostTestAdapterSettings.#EnableStdOutRedirection")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Std", Scope = "member", Target = "BoostTestAdapter.Settings.BoostTestAdapterSettings.#EnableStdErrRedirection")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "BoostTestAdapter.Settings.TestSourceFilter.#Include")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "BoostTestAdapter.Settings.TestSourceFilter.#Include")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "BoostTestAdapter.Settings.TestSourceFilter.#Exclude")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "BoostTestAdapter.Settings.TestSourceFilter.#Exclude")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "BoostTestAdapter.Utility.BoostTestRunnerCommandLineArgsEx")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "BoostTestAdapter.Boost.Runner.BoostTest162Runner.#Execute(BoostTestAdapter.Boost.Runner.BoostTestRunnerCommandLineArgs,BoostTestAdapter.Boost.Runner.BoostTestRunnerSettings,BoostTestAdapter.Utility.ExecutionContext.IProcessExecutionContext)")]

