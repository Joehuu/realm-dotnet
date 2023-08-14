﻿// <auto-generated />
#nullable enable

using Realms;
using Realms.Schema;
using Realms.Weaving;
using SourceGeneratorPlayground;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SourceGeneratorPlayground
{
    public partial class OuterClass
    {
        [Generated]
        [Woven(typeof(NestedClassObjectHelper)), Realms.Preserve(AllMembers = true)]
        private partial class NestedClass : IRealmObject, INotifyPropertyChanged, IReflectableType
        {
            /// <summary>
            /// Defines the schema for the <see cref="NestedClass"/> class.
            /// </summary>
            public static Realms.Schema.ObjectSchema RealmSchema = new Realms.Schema.ObjectSchema.Builder("NestedClass", ObjectSchema.ObjectType.RealmObject)
            {
                Realms.Schema.Property.Primitive("Id", Realms.RealmValueType.Int, isPrimaryKey: false, indexType: IndexType.None, isNullable: false, managedName: "Id"),
                Realms.Schema.Property.Object("Link", "NestedClass", managedName: "Link"),
            }.Build();

            #region IRealmObject implementation

            private INestedClassAccessor? _accessor;

            Realms.IRealmAccessor Realms.IRealmObjectBase.Accessor => Accessor;

            private INestedClassAccessor Accessor => _accessor ??= new NestedClassUnmanagedAccessor(typeof(NestedClass));

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public bool IsManaged => Accessor.IsManaged;

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public bool IsValid => Accessor.IsValid;

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public bool IsFrozen => Accessor.IsFrozen;

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public Realms.Realm? Realm => Accessor.Realm;

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public Realms.Schema.ObjectSchema ObjectSchema => Accessor.ObjectSchema!;

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public Realms.DynamicObjectApi DynamicApi => Accessor.DynamicApi;

            /// <inheritdoc />
            [IgnoreDataMember, XmlIgnore]
            public int BacklinksCount => Accessor.BacklinksCount;

            void ISettableManagedAccessor.SetManagedAccessor(Realms.IRealmAccessor managedAccessor, Realms.Weaving.IRealmObjectHelper? helper, bool update, bool skipDefaults)
            {
                var newAccessor = (INestedClassAccessor)managedAccessor;
                var oldAccessor = _accessor;
                _accessor = newAccessor;

                if (helper != null && oldAccessor != null)
                {
                    if (!skipDefaults || oldAccessor.Id != default(int))
                    {
                        newAccessor.Id = oldAccessor.Id;
                    }
                    if (oldAccessor.Link != null && newAccessor.Realm != null)
                    {
                        newAccessor.Realm.Add(oldAccessor.Link, update);
                    }
                    newAccessor.Link = oldAccessor.Link;
                }

                if (_propertyChanged != null)
                {
                    SubscribeForNotifications();
                }

                OnManaged();
            }

            #endregion

            /// <summary>
            /// Called when the object has been managed by a Realm.
            /// </summary>
            /// <remarks>
            /// This method will be called either when a managed object is materialized or when an unmanaged object has been
            /// added to the Realm. It can be useful for providing some initialization logic as when the constructor is invoked,
            /// it is not yet clear whether the object is managed or not.
            /// </remarks>
            partial void OnManaged();

            private event PropertyChangedEventHandler? _propertyChanged;

            /// <inheritdoc />
            public event PropertyChangedEventHandler? PropertyChanged
            {
                add
                {
                    if (_propertyChanged == null)
                    {
                        SubscribeForNotifications();
                    }

                    _propertyChanged += value;
                }

                remove
                {
                    _propertyChanged -= value;

                    if (_propertyChanged == null)
                    {
                        UnsubscribeFromNotifications();
                    }
                }
            }

            /// <summary>
            /// Called when a property has changed on this class.
            /// </summary>
            /// <param name="propertyName">The name of the property.</param>
            /// <remarks>
            /// For this method to be called, you need to have first subscribed to <see cref="PropertyChanged"/>.
            /// This can be used to react to changes to the current object, e.g. raising <see cref="PropertyChanged"/> for computed properties.
            /// </remarks>
            /// <example>
            /// <code>
            /// class MyClass : IRealmObject
            /// {
            ///     public int StatusCodeRaw { get; set; }
            ///     public StatusCodeEnum StatusCode => (StatusCodeEnum)StatusCodeRaw;
            ///     partial void OnPropertyChanged(string propertyName)
            ///     {
            ///         if (propertyName == nameof(StatusCodeRaw))
            ///         {
            ///             RaisePropertyChanged(nameof(StatusCode));
            ///         }
            ///     }
            /// }
            /// </code>
            /// Here, we have a computed property that depends on a persisted one. In order to notify any <see cref="PropertyChanged"/>
            /// subscribers that <c>StatusCode</c> has changed, we implement <see cref="OnPropertyChanged"/> and
            /// raise <see cref="PropertyChanged"/> manually by calling <see cref="RaisePropertyChanged"/>.
            /// </example>
            partial void OnPropertyChanged(string? propertyName);

            private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
            {
                _propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                OnPropertyChanged(propertyName);
            }

            private void SubscribeForNotifications()
            {
                Accessor.SubscribeForNotifications(RaisePropertyChanged);
            }

            private void UnsubscribeFromNotifications()
            {
                Accessor.UnsubscribeFromNotifications();
            }

            /// <summary>
            /// Converts a <see cref="Realms.RealmValue"/> to <see cref="NestedClass"/>. Equivalent to <see cref="Realms.RealmValue.AsNullableRealmObject{T}"/>.
            /// </summary>
            /// <param name="val">The <see cref="Realms.RealmValue"/> to convert.</param>
            /// <returns>The <see cref="NestedClass"/> stored in the <see cref="Realms.RealmValue"/>.</returns>
            public static explicit operator NestedClass?(Realms.RealmValue val) => val.Type == Realms.RealmValueType.Null ? null : val.AsRealmObject<NestedClass>();

            /// <summary>
            /// Implicitly constructs a <see cref="Realms.RealmValue"/> from <see cref="NestedClass"/>.
            /// </summary>
            /// <param name="val">The value to store in the <see cref="Realms.RealmValue"/>.</param>
            /// <returns>A <see cref="Realms.RealmValue"/> containing the supplied <paramref name="val"/>.</returns>
            public static implicit operator Realms.RealmValue(NestedClass? val) => val == null ? Realms.RealmValue.Null : Realms.RealmValue.Object(val);

            /// <summary>
            /// Implicitly constructs a <see cref="Realms.QueryArgument"/> from <see cref="NestedClass"/>.
            /// </summary>
            /// <param name="val">The value to store in the <see cref="Realms.QueryArgument"/>.</param>
            /// <returns>A <see cref="Realms.QueryArgument"/> containing the supplied <paramref name="val"/>.</returns>
            public static implicit operator Realms.QueryArgument(NestedClass? val) => (Realms.RealmValue)val;

            /// <inheritdoc />
            [EditorBrowsable(EditorBrowsableState.Never)]
            public TypeInfo GetTypeInfo() => Accessor.GetTypeInfo(this);

            /// <inheritdoc />
            public override bool Equals(object? obj)
            {
                if (obj is null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (obj is InvalidObject)
                {
                    return !IsValid;
                }

                if (obj is not Realms.IRealmObjectBase iro)
                {
                    return false;
                }

                return Accessor.Equals(iro.Accessor);
            }

            /// <inheritdoc />
            public override int GetHashCode() => IsManaged ? Accessor.GetHashCode() : base.GetHashCode();

            /// <inheritdoc />
            public override string? ToString() => Accessor.ToString();

            [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
            private class NestedClassObjectHelper : Realms.Weaving.IRealmObjectHelper
            {
                public void CopyToRealm(Realms.IRealmObjectBase instance, bool update, bool skipDefaults)
                {
                    throw new InvalidOperationException("This method should not be called for source generated classes.");
                }

                public Realms.ManagedAccessor CreateAccessor() => new NestedClassManagedAccessor();

                public Realms.IRealmObjectBase CreateInstance() => new NestedClass();

                public bool TryGetPrimaryKeyValue(Realms.IRealmObjectBase instance, out RealmValue value)
                {
                    value = RealmValue.Null;
                    return false;
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
            internal interface INestedClassAccessor : Realms.IRealmAccessor
            {
                int Id { get; set; }

                SourceGeneratorPlayground.OuterClass.NestedClass? Link { get; set; }
            }

            [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
            internal class NestedClassManagedAccessor : Realms.ManagedAccessor, INestedClassAccessor
            {
                public int Id
                {
                    get => (int)GetValue("Id");
                    set => SetValue("Id", value);
                }

                public SourceGeneratorPlayground.OuterClass.NestedClass? Link
                {
                    get => (SourceGeneratorPlayground.OuterClass.NestedClass?)GetValue("Link");
                    set => SetValue("Link", value);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
            internal class NestedClassUnmanagedAccessor : Realms.UnmanagedAccessor, INestedClassAccessor
            {
                public override ObjectSchema ObjectSchema => NestedClass.RealmSchema;

                private int _id;
                public int Id
                {
                    get => _id;
                    set
                    {
                        _id = value;
                        RaisePropertyChanged("Id");
                    }
                }

                private SourceGeneratorPlayground.OuterClass.NestedClass? _link;
                public SourceGeneratorPlayground.OuterClass.NestedClass? Link
                {
                    get => _link;
                    set
                    {
                        _link = value;
                        RaisePropertyChanged("Link");
                    }
                }

                public NestedClassUnmanagedAccessor(Type objectType) : base(objectType)
                {
                }

                public override Realms.RealmValue GetValue(string propertyName)
                {
                    return propertyName switch
                    {
                        "Id" => _id,
                        "Link" => _link,
                        _ => throw new MissingMemberException($"The object does not have a gettable Realm property with name {propertyName}"),
                    };
                }

                public override void SetValue(string propertyName, Realms.RealmValue val)
                {
                    switch (propertyName)
                    {
                        case "Id":
                            Id = (int)val;
                            return;
                        case "Link":
                            Link = (SourceGeneratorPlayground.OuterClass.NestedClass?)val;
                            return;
                        default:
                            throw new MissingMemberException($"The object does not have a settable Realm property with name {propertyName}");
                    }
                }

                public override void SetValueUnique(string propertyName, Realms.RealmValue val)
                {
                    throw new InvalidOperationException("Cannot set the value of an non primary key property with SetValueUnique");
                }

                public override IList<T> GetListValue<T>(string propertyName)
                {
                    throw new MissingMemberException($"The object does not have a Realm list property with name {propertyName}");
                }

                public override ISet<T> GetSetValue<T>(string propertyName)
                {
                    throw new MissingMemberException($"The object does not have a Realm set property with name {propertyName}");
                }

                public override IDictionary<string, TValue> GetDictionaryValue<TValue>(string propertyName)
                {
                    throw new MissingMemberException($"The object does not have a Realm dictionary property with name {propertyName}");
                }
            }
        }
    }
}
