﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[JsonFormatter(typeof(PropertiesFormatter))]
	public interface IProperties : IIsADictionary<PropertyName, IProperty> { }

	public class Properties : IsADictionaryBase<PropertyName, IProperty>, IProperties
	{
		private readonly IConnectionSettingsValues _settings;

		public Properties() { }

		public Properties(IDictionary<PropertyName, IProperty> container) : base(container) { }

		public Properties(Dictionary<PropertyName, IProperty> container) : base(container) { }

		internal Properties(IConnectionSettingsValues values) => _settings = values;

		public void Add(PropertyName name, IProperty property) => BackingDictionary.Add(Sanitize(name), property);

		protected override PropertyName Sanitize(PropertyName key) => _settings?.Inferrer.PropertyName(key) ?? key;
	}

	public class Properties<T> : IsADictionaryBase<PropertyName, IProperty>, IProperties
	{
		public Properties() { }

		public Properties(IDictionary<PropertyName, IProperty> container) : base(container) { }

		public Properties(IProperties properties) : base(properties) { }

		public Properties(Dictionary<PropertyName, IProperty> container) : base(container) { }

		public void Add(PropertyName name, IProperty property) => BackingDictionary.Add(name, property);

		public void Add<TValue>(Expression<Func<T, TValue>> name, IProperty property) => BackingDictionary.Add(name, property);
	}

	public partial interface IPropertiesDescriptor<T, out TReturnType>
		where T : class
		where TReturnType : class
	{
		TReturnType Text(Func<TextPropertyDescriptor<T>, ITextProperty> selector);

		TReturnType Keyword(Func<KeywordPropertyDescriptor<T>, IKeywordProperty> selector);

		/// <summary>
		/// Number introduces a numeric mapping that defaults to `float`. Use .Type() to set the right type if needed or use
		/// Scalar instead of <see cref="Number" />
		/// </summary>
		TReturnType Number(Func<NumberPropertyDescriptor<T>, INumberProperty> selector);

		TReturnType TokenCount(Func<TokenCountPropertyDescriptor<T>, ITokenCountProperty> selector);

		TReturnType Date(Func<DatePropertyDescriptor<T>, IDateProperty> selector);

		TReturnType DateNanos(Func<DateNanosPropertyDescriptor<T>, IDateNanosProperty> selector);

		TReturnType Boolean(Func<BooleanPropertyDescriptor<T>, IBooleanProperty> selector);

		TReturnType Binary(Func<BinaryPropertyDescriptor<T>, IBinaryProperty> selector);

		TReturnType Object<TChild>(Func<ObjectTypeDescriptor<T, TChild>, IObjectProperty> selector)
			where TChild : class;

		TReturnType Nested<TChild>(Func<NestedPropertyDescriptor<T, TChild>, INestedProperty> selector)
			where TChild : class;

		TReturnType Ip(Func<IpPropertyDescriptor<T>, IIpProperty> selector);

		TReturnType GeoPoint(Func<GeoPointPropertyDescriptor<T>, IGeoPointProperty> selector);

		TReturnType GeoShape(Func<GeoShapePropertyDescriptor<T>, IGeoShapeProperty> selector);

		TReturnType Shape(Func<ShapePropertyDescriptor<T>, IShapeProperty> selector);

		TReturnType Completion(Func<CompletionPropertyDescriptor<T>, ICompletionProperty> selector);

		TReturnType Murmur3Hash(Func<Murmur3HashPropertyDescriptor<T>, IMurmur3HashProperty> selector);

		TReturnType Percolator(Func<PercolatorPropertyDescriptor<T>, IPercolatorProperty> selector);

		TReturnType DateRange(Func<DateRangePropertyDescriptor<T>, IDateRangeProperty> selector);

		TReturnType DoubleRange(Func<DoubleRangePropertyDescriptor<T>, IDoubleRangeProperty> selector);

		TReturnType FloatRange(Func<FloatRangePropertyDescriptor<T>, IFloatRangeProperty> selector);

		TReturnType IntegerRange(Func<IntegerRangePropertyDescriptor<T>, IIntegerRangeProperty> selector);

		TReturnType LongRange(Func<LongRangePropertyDescriptor<T>, ILongRangeProperty> selector);

		TReturnType IpRange(Func<IpRangePropertyDescriptor<T>, IIpRangeProperty> selector);

		TReturnType Join(Func<JoinPropertyDescriptor<T>, IJoinProperty> selector);
	}

	public partial class PropertiesDescriptor<T> where T : class
	{
		public PropertiesDescriptor() : base(new Properties<T>()) { }

		public PropertiesDescriptor(IProperties properties) : base(properties ?? new Properties<T>()) { }

		public PropertiesDescriptor<T> Binary(Func<BinaryPropertyDescriptor<T>, IBinaryProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Boolean(Func<BooleanPropertyDescriptor<T>, IBooleanProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Completion(Func<CompletionPropertyDescriptor<T>, ICompletionProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Date(Func<DatePropertyDescriptor<T>, IDateProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> DateNanos(Func<DateNanosPropertyDescriptor<T>, IDateNanosProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> DateRange(Func<DateRangePropertyDescriptor<T>, IDateRangeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> DoubleRange(Func<DoubleRangePropertyDescriptor<T>, IDoubleRangeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> FloatRange(Func<FloatRangePropertyDescriptor<T>, IFloatRangeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> GeoPoint(Func<GeoPointPropertyDescriptor<T>, IGeoPointProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> GeoShape(Func<GeoShapePropertyDescriptor<T>, IGeoShapeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Shape(Func<ShapePropertyDescriptor<T>, IShapeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> IntegerRange(Func<IntegerRangePropertyDescriptor<T>, IIntegerRangeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Ip(Func<IpPropertyDescriptor<T>, IIpProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> IpRange(Func<IpRangePropertyDescriptor<T>, IIpRangeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Join(Func<JoinPropertyDescriptor<T>, IJoinProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Keyword(Func<KeywordPropertyDescriptor<T>, IKeywordProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> LongRange(Func<LongRangePropertyDescriptor<T>, ILongRangeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Murmur3Hash(Func<Murmur3HashPropertyDescriptor<T>, IMurmur3HashProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Nested<TChild>(Func<NestedPropertyDescriptor<T, TChild>, INestedProperty> selector)
			where TChild : class => SetProperty(selector);

		/// <summary>
		/// Number introduces a numeric mapping that defaults to <c>float</c>. use
		/// <see cref="IProperty.Type" /> to set the right type if needed, or use .Scalar()
		/// instead of <see cref="Number" />
		/// </summary>
		public PropertiesDescriptor<T> Number(Func<NumberPropertyDescriptor<T>, INumberProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Object<TChild>(Func<ObjectTypeDescriptor<T, TChild>, IObjectProperty> selector)
			where TChild : class => SetProperty(selector);

		public PropertiesDescriptor<T> Percolator(Func<PercolatorPropertyDescriptor<T>, IPercolatorProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Text(Func<TextPropertyDescriptor<T>, ITextProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> SearchAsYouType(Func<SearchAsYouTypePropertyDescriptor<T>, ISearchAsYouTypeProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> TokenCount(Func<TokenCountPropertyDescriptor<T>, ITokenCountProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> FieldAlias(Func<FieldAliasPropertyDescriptor<T>, IFieldAliasProperty> selector) => SetProperty(selector);

		/// <inheritdoc cref="IRankFeatureProperty"/>
		public PropertiesDescriptor<T> RankFeature(Func<RankFeaturePropertyDescriptor<T>, IRankFeatureProperty> selector) => SetProperty(selector);

		/// <inheritdoc cref="IRankFeaturesProperty"/>
		public PropertiesDescriptor<T> RankFeatures(Func<RankFeaturesPropertyDescriptor<T>, IRankFeaturesProperty> selector) => SetProperty(selector);

		/// <inheritdoc cref="IFlattenedProperty"/>
		public PropertiesDescriptor<T> Flattened(Func<FlattenedPropertyDescriptor<T>, IFlattenedProperty> selector) => SetProperty(selector);

		public PropertiesDescriptor<T> Custom(IProperty customType) => SetProperty(customType);

		private PropertiesDescriptor<T> SetProperty<TDescriptor, TInterface>(Func<TDescriptor, TInterface> selector)
			where TDescriptor : class, TInterface, new()
			where TInterface : IProperty
		{
			selector.ThrowIfNull(nameof(selector));
			var type = selector(new TDescriptor());
			return SetProperty(type);
		}

		private PropertiesDescriptor<T> SetProperty(IProperty type)
		{
			type.ThrowIfNull(nameof(type));
			var typeName = type.GetType().Name;
			if (type.Name.IsConditionless())
				throw new ArgumentException($"Could not get field name for {typeName} mapping");

			return Assign(type, (a, v) => a[v.Name] = v);
		}
	}

	internal static class PropertiesExtensions
	{
		internal static IProperties AutoMap(this IProperties existingProperties, Type documentType, IPropertyVisitor visitor = null,
			int maxRecursion = 0
		)
		{
			var properties = new Properties();
			var autoProperties = new PropertyWalker(documentType, visitor, maxRecursion).GetProperties();
			foreach (var autoProperty in autoProperties)
				properties[autoProperty.Key] = autoProperty.Value;

			if (existingProperties == null) return properties;

			// Existing/manually mapped properties always take precedence
			foreach (var existing in existingProperties)
				properties[existing.Key] = existing.Value;

			return properties;
		}

		internal static IProperties AutoMap<T>(this IProperties existingProperties, IPropertyVisitor visitor = null, int maxRecursion = 0)
			where T : class => existingProperties.AutoMap(typeof(T), visitor, maxRecursion);
	}
}
