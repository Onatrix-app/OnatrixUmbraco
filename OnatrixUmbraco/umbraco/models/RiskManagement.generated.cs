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
	/// <summary>RiskManagement</summary>
	[PublishedModel("riskManagement")]
	public partial class RiskManagement : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "riskManagement";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<RiskManagement, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public RiskManagement(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// AboutUsCornerText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsCornerText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsCornerText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsCornerText");

		///<summary>
		/// AboutUsCornerTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsCornerTitle")]
		public virtual string AboutUsCornerTitle => this.Value<string>(_publishedValueFallback, "aboutUsCornerTitle");

		///<summary>
		/// ContactInformationAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationAddress")]
		public virtual string ContactInformationAddress => this.Value<string>(_publishedValueFallback, "contactInformationAddress");

		///<summary>
		/// ContactInformationEmail
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationEmail")]
		public virtual string ContactInformationEmail => this.Value<string>(_publishedValueFallback, "contactInformationEmail");

		///<summary>
		/// ContactInformationEmailAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationEmailAddress")]
		public virtual string ContactInformationEmailAddress => this.Value<string>(_publishedValueFallback, "contactInformationEmailAddress");

		///<summary>
		/// ContactInformationLocation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationLocation")]
		public virtual string ContactInformationLocation => this.Value<string>(_publishedValueFallback, "contactInformationLocation");

		///<summary>
		/// ContactInformationPhone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationPhone")]
		public virtual string ContactInformationPhone => this.Value<string>(_publishedValueFallback, "contactInformationPhone");

		///<summary>
		/// ContactInformationPhoneNumber
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationPhoneNumber")]
		public virtual string ContactInformationPhoneNumber => this.Value<string>(_publishedValueFallback, "contactInformationPhoneNumber");

		///<summary>
		/// ContactInformationPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ContactInformationPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "contactInformationPicture");

		///<summary>
		/// ContactInformationTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ContactInformationTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "contactInformationTitle");

		///<summary>
		/// FooterPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FooterPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "footerPicture");

		///<summary>
		/// HeaderLogo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "headerLogo");

		///<summary>
		/// RiskmanagementMainDownText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainDownText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskmanagementMainDownText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskmanagementMainDownText");

		///<summary>
		/// RiskmanagementMainDownTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainDownTitle")]
		public virtual string RiskmanagementMainDownTitle => this.Value<string>(_publishedValueFallback, "riskmanagementMainDownTitle");

		///<summary>
		/// RiskmanagementMainFormTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainFormTitle")]
		public virtual string RiskmanagementMainFormTitle => this.Value<string>(_publishedValueFallback, "riskmanagementMainFormTitle");

		///<summary>
		/// RiskmanagementMainMiddlePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainMiddlePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RiskmanagementMainMiddlePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "riskmanagementMainMiddlePicture");

		///<summary>
		/// RiskmanagementMainMiddleText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainMiddleText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskmanagementMainMiddleText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskmanagementMainMiddleText");

		///<summary>
		/// RiskmanagementMainMiddleTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainMiddleTitle")]
		public virtual string RiskmanagementMainMiddleTitle => this.Value<string>(_publishedValueFallback, "riskmanagementMainMiddleTitle");

		///<summary>
		/// RiskManagementMainPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RiskManagementMainPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "riskManagementMainPicture");

		///<summary>
		/// RiskmanagementMainPictureRight
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainPictureRight")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RiskmanagementMainPictureRight => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "riskmanagementMainPictureRight");

		///<summary>
		/// RiskmanagementMainRightText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainRightText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskmanagementMainRightText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskmanagementMainRightText");

		///<summary>
		/// RiskmanagementMainRightTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskmanagementMainRightTitle")]
		public virtual string RiskmanagementMainRightTitle => this.Value<string>(_publishedValueFallback, "riskmanagementMainRightTitle");

		///<summary>
		/// RiskManagementMainText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskManagementMainText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskManagementMainText");

		///<summary>
		/// RiskManagementMainTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainTitle")]
		public virtual string RiskManagementMainTitle => this.Value<string>(_publishedValueFallback, "riskManagementMainTitle");

		///<summary>
		/// RiskManagementText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementText")]
		public virtual string RiskManagementText => this.Value<string>(_publishedValueFallback, "riskManagementText");

		///<summary>
		/// RiskManagementTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementTitle")]
		public virtual string RiskManagementTitle => this.Value<string>(_publishedValueFallback, "riskManagementTitle");
	}
}
