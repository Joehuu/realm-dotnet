﻿using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "Copied from Xamarin's implementation", Scope = "type", Target = "~T:Realms.PreserveAttribute")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "Copied from Xamarin's implementation", Scope = "type", Target = "~T:Realms.PreserveAttribute")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Shouldn't be used directly.", Scope = "type", Target = "~T:Realms.Dynamic.DynamicRealmObject")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Shouldn't be used directly.", Scope = "type", Target = "~T:Realms.Dynamic.DynamicEmbeddedObject")]
[assembly: SuppressMessage("Performance", "CA1820:Test for empty strings using string length", Justification = "We're only capturing the method group.", Scope = "type", Target = "~T:Realms.RealmResultsVisitor.Methods.String")]
[assembly: SuppressMessage("Usage", "CA2208:Instantiate argument exceptions correctly", Justification = "index is the argument name for ElementAt.", Scope = "member", Target = "~M:Realms.RealmResultsVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)~System.Linq.Expressions.Expression")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:Use built-in type alias", Justification = "Native structs use verbose names.", Scope = "namespaceanddescendants", Target = "~N:Realms.Native")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:Accessible fields should begin with upper-case letter", Justification = "Native structs use snake_case fields.", Scope = "namespaceanddescendants", Target = "~N:Realms.Native")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element should begin with upper-case letter", Justification = "Native methods are snake_case.", Scope = "type", Target = "~T:Realms.NativeCommon")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Native methods are snake_case.", Scope = "type", Target = "~T:Realms.NativeCommon")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:Accessible fields should begin with upper-case letter", Justification = "Native structs use snake_case fields.", Scope = "type", Target = "~T:Realms.NativeException")]
[assembly: SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:Use built-in type alias", Justification = "Native structs use verbose names.", Scope = "namespaceanddescendants", Target = "~N:Realms.Sync.Native")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1307:Accessible fields should begin with upper-case letter", Justification = "Native structs use snake_case fields.", Scope = "namespaceanddescendants", Target = "~N:Realms.Sync.Native")]
[assembly: SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "Private struct fields are important for correct offsets while marshalling", Scope = "namespaceanddescendants", Target = "~N:Realms.Sync.Native")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element should begin with upper-case letter", Justification = "Native methods are snake_case.", Scope = "type", Target = "~T:Realms.SynchronizationContextScheduler")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Native methods are snake_case.", Scope = "type", Target = "~T:Realms.SynchronizationContextScheduler")]
[assembly: SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Will be a breaking change to rename.", Scope = "type", Target = "~T:Realms.Schema.Property")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the private event", Scope = "member", Target = "~E:Realms.RealmCollectionBase`1._collectionChanged")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the private event", Scope = "member", Target = "~E:Realms.RealmCollectionBase`1._propertyChanged")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the private event", Scope = "member", Target = "~E:Realms.RealmObjectBase._propertyChanged")]
[assembly: SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "This is the private event", Scope = "member", Target = "~E:Realms.Realm._realmChanged")]
[assembly: SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "The values of the enum represent types.", Scope = "type", Target = "~T:Realms.RealmValueType")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Doesn't need docs", Scope = "type", Target = "~T:Realms.Helpers.Operator.ISpecializedConverter`2")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Doesn't need docs", Scope = "member", Target = "~P:Realms.Helpers.Operator.IGenericConverter`1.SourceType")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Doesn't need docs", Scope = "member", Target = "~M:Realms.Helpers.Operator.IGenericConverter`1.Convert(System.Object)~`0")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Builder is not supposed to be extended by users", Scope = "member", Target = "~M:Realms.Schema.SchemaBuilderBase`1.GetKey(`0)~System.String")]
[assembly: SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "Builder is not supposed to be extended by users", Scope = "member", Target = "~F:Realms.Schema.SchemaBuilderBase`1._values")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Builder is not supposed to be extended by users", Scope = "member", Target = "~F:Realms.Schema.SchemaBuilderBase`1._values")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Builder is not supposed to be extended by users", Scope = "member", Target = "~M:Realms.Schema.SchemaBuilderBase`1.Add(`0)")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Builder is not supposed to be extended by users", Scope = "member", Target = "~M:Realms.Schema.ObjectSchema.Builder.GetKey(Realms.Schema.Property)~System.String")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Builder is not supposed to be extended by users", Scope = "member", Target = "~M:Realms.Schema.RealmSchema.Builder.GetKey(Realms.Schema.ObjectSchema)~System.String")]
[assembly: SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1000:Keywords should be spaced correctly", Justification = "In C# 9.0 we can use new() to instantiate objects and we don't need a space there", Scope = "module")]
