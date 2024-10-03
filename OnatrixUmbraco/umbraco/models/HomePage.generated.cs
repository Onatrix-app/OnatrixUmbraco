//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// AboutUsDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsDescription");

		///<summary>
		/// AboutUsFormText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsFormText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsFormText");

		///<summary>
		/// AboutUsFormTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsFormTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsFormTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsFormTitle");

		///<summary>
		/// AboutUsPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AboutUsPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "aboutUsPicture");

		///<summary>
		/// AboutUsRole
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsRole")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsRole => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsRole");

		///<summary>
		/// AboutUsText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsText");

		///<summary>
		/// AbsoutUsTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("absoutUsTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AbsoutUsTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "absoutUsTitle");

		///<summary>
		/// FooterImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FooterImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "footerImage");

		///<summary>
		/// HeaderLogo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "headerLogo");

		///<summary>
		/// HeroPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeroPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "heroPicture");

		///<summary>
		/// HeroText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString HeroText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "heroText");

		///<summary>
		/// HeroTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString HeroTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "heroTitle");

		///<summary>
		/// OurProjectBoxFourPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxFourPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectBoxFourPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectBoxFourPicture");

		///<summary>
		/// OurProjectBoxFourText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxFourText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxFourText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxFourText");

		///<summary>
		/// OurProjectBoxFourTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxFourTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxFourTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxFourTitle");

		///<summary>
		/// OurProjectBoxOnePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxOnePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectBoxOnePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectBoxOnePicture");

		///<summary>
		/// OurProjectBoxOneText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxOneText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxOneText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxOneText");

		///<summary>
		/// OurProjectBoxOneTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxOneTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxOneTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxOneTitle");

		///<summary>
		/// OurProjectBoxThreePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxThreePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectBoxThreePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectBoxThreePicture");

		///<summary>
		/// OurProjectBoxThreeText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxThreeText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxThreeText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxThreeText");

		///<summary>
		/// OurProjectBoxThreeTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxThreeTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxThreeTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxThreeTitle");

		///<summary>
		/// OurProjectBoxTwoPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxTwoPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurProjectBoxTwoPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourProjectBoxTwoPicture");

		///<summary>
		/// OurProjectBoxTwoText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxTwoText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxTwoText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxTwoText");

		///<summary>
		/// OurProjectBoxTwoTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectBoxTwoTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectBoxTwoTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectBoxTwoTitle");

		///<summary>
		/// OurProjectText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectText");

		///<summary>
		/// OurProjectTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourProjectTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurProjectTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourProjectTitle");

		///<summary>
		/// OurServicesBoxFivePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxFivePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurServicesBoxFivePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourServicesBoxFivePicture");

		///<summary>
		/// OurServicesBoxFiveText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxFiveText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxFiveText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxFiveText");

		///<summary>
		/// OurServicesBoxFiveTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxFiveTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxFiveTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxFiveTitle");

		///<summary>
		/// OurServicesBoxFourPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxFourPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurServicesBoxFourPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourServicesBoxFourPicture");

		///<summary>
		/// OurServicesBoxFourText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxFourText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxFourText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxFourText");

		///<summary>
		/// OurServicesBoxFourTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxFourTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxFourTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxFourTitle");

		///<summary>
		/// OurServicesBoxOnePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxOnePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurServicesBoxOnePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourServicesBoxOnePicture");

		///<summary>
		/// OurServicesBoxOneText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxOneText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxOneText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxOneText");

		///<summary>
		/// OurServicesBoxOneTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxOneTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxOneTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxOneTitle");

		///<summary>
		/// OurServicesBoxSixPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxSixPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurServicesBoxSixPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourServicesBoxSixPicture");

		///<summary>
		/// OurServicesBoxSixText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxSixText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxSixText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxSixText");

		///<summary>
		/// OurServicesBoxSixTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxSixTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxSixTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxSixTitle");

		///<summary>
		/// OurServicesBoxThreePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxThreePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurServicesBoxThreePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourServicesBoxThreePicture");

		///<summary>
		/// OurServicesBoxThreeText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxThreeText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxThreeText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxThreeText");

		///<summary>
		/// OurServicesBoxThreeTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxThreeTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxThreeTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxThreeTitle");

		///<summary>
		/// OurServicesBoxTwoPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxTwoPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurServicesBoxTwoPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourServicesBoxTwoPicture");

		///<summary>
		/// OurServicesBoxTwoText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxTwoText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxTwoText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxTwoText");

		///<summary>
		/// OurServicesBoxTwoTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesBoxTwoTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesBoxTwoTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesBoxTwoTitle");

		///<summary>
		/// OurServicesDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesDescription");

		///<summary>
		/// OurServicesTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourServicesTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurServicesTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourServicesTitle");

		///<summary>
		/// OurStoryPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurStoryPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourStoryPicture");

		///<summary>
		/// OurStoryText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurStoryText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourStoryText");

		///<summary>
		/// OurStoryTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourStoryTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString OurStoryTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "ourStoryTitle");

		///<summary>
		/// SuccessStoryBoxOneNumber
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBoxOneNumber")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryBoxOneNumber => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryBoxOneNumber");

		///<summary>
		/// SuccessStoryBoxOneText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBoxOneText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryBoxOneText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryBoxOneText");

		///<summary>
		/// SuccessStoryBoxThreeNumber
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBoxThreeNumber")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryBoxThreeNumber => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryBoxThreeNumber");

		///<summary>
		/// SuccessStoryBoxThreeText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBoxThreeText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryBoxThreeText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryBoxThreeText");

		///<summary>
		/// SuccessStoryBoxTwoNumber
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBoxTwoNumber")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryBoxTwoNumber => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryBoxTwoNumber");

		///<summary>
		/// SuccessStoryBoxTwoText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryBoxTwoText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryBoxTwoText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryBoxTwoText");

		///<summary>
		/// SuccessStoryPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SuccessStoryPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "successStoryPicture");

		///<summary>
		/// SuccessStoryText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryText");

		///<summary>
		/// SuccessStoryTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successStoryTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SuccessStoryTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "successStoryTitle");
	}
}
