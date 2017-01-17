﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangouts.DataAccess
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hangouts")]
	public partial class HangoutsDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public HangoutsDBDataContext() : 
				base(global::Hangouts.DataAccess.Properties.Settings.Default.HangoutsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HangoutsDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangoutsDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangoutsDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangoutsDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RetrieveRatingsByUserId")]
		public ISingleResult<RetrieveRatingsByUserIdResult> RetrieveRatingsByUserId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<RetrieveRatingsByUserIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RetrieveWineDetails")]
		public ISingleResult<RetrieveWineDetailsResult> RetrieveWineDetails([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="Int")] System.Nullable<int> sKU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sKU);
			return ((ISingleResult<RetrieveWineDetailsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RetrieveAvailableWines")]
		public ISingleResult<RetrieveAvailableWinesResult> RetrieveAvailableWines([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PlantFinal", DbType="Int")] System.Nullable<int> plantFinal)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), plantFinal);
			return ((ISingleResult<RetrieveAvailableWinesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUpdateLike")]
		public int InsertUpdateLike([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="Int")] System.Nullable<int> sKU, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Liked", DbType="Bit")] System.Nullable<bool> liked)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID, sKU, liked);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RetrieveRatingsBySKU")]
		public ISingleResult<RetrieveRatingsBySKUResult> RetrieveRatingsBySKU([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="Int")] System.Nullable<int> sKU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sKU);
			return ((ISingleResult<RetrieveRatingsBySKUResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUpdateReview")]
		public int InsertUpdateReview([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewID", DbType="Int")] System.Nullable<int> reviewID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PlantFinal", DbType="VarChar(10)")] string plantFinal, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewDate", DbType="DateTime")] System.Nullable<System.DateTime> reviewDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CardID", DbType="Int")] System.Nullable<int> cardID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cost", DbType="Decimal(18,4)")] System.Nullable<decimal> cost, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RatingStars", DbType="Int")] System.Nullable<int> ratingStars, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="Int")] System.Nullable<int> sKU, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CommentsTitle", DbType="NVarChar(1)")] string commentsTitle, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RatingText", DbType="NVarChar(1)")] string ratingText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewUserId", DbType="Int")] System.Nullable<int> reviewUserId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(1)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), reviewID, plantFinal, reviewDate, cardID, cost, ratingStars, sKU, commentsTitle, ratingText, reviewUserId, name, isActive);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteReview")]
		public int DeleteReview([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="Int")] System.Nullable<int> sKU, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReviewUserId", DbType="Int")] System.Nullable<int> reviewUserId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sKU, reviewUserId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AuthenticateUser")]
		public ISingleResult<AuthenticateUserResult> AuthenticateUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(MAX)")] string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name);
			return ((ISingleResult<AuthenticateUserResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RetrieveReviewsBySKU")]
		public ISingleResult<RetrieveReviewsBySKUResult> RetrieveReviewsBySKU([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SKU", DbType="Int")] System.Nullable<int> sKU)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sKU);
			return ((ISingleResult<RetrieveReviewsBySKUResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RetrieveReviewsByUserId")]
		public ISingleResult<RetrieveReviewsByUserIdResult> RetrieveReviewsByUserId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<RetrieveReviewsByUserIdResult>)(result.ReturnValue));
		}
	}
	
	public partial class RetrieveRatingsByUserIdResult
	{
		
		private int _RatingStars;
		
		private string _RatingText;
		
		private System.DateTime _Date;
		
		private System.Nullable<int> _UserName;
		
		private System.Nullable<int> _SKU;
		
		private string _Name;
		
		private System.Nullable<int> _Vintage;
		
		private string _Region;
		
		private string _Country;
		
		public RetrieveRatingsByUserIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingStars", DbType="Int NOT NULL")]
		public int RatingStars
		{
			get
			{
				return this._RatingStars;
			}
			set
			{
				if ((this._RatingStars != value))
				{
					this._RatingStars = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingText", DbType="NVarChar(MAX)")]
		public string RatingText
		{
			get
			{
				return this._RatingText;
			}
			set
			{
				if ((this._RatingText != value))
				{
					this._RatingText = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="Int")]
		public System.Nullable<int> UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="Int")]
		public System.Nullable<int> SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vintage", DbType="Int")]
		public System.Nullable<int> Vintage
		{
			get
			{
				return this._Vintage;
			}
			set
			{
				if ((this._Vintage != value))
				{
					this._Vintage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
	}
	
	public partial class RetrieveWineDetailsResult
	{
		
		private int _SKU;
		
		private string _Name;
		
		private System.Nullable<int> _Vintage;
		
		private string _Country;
		
		private string _Region;
		
		private string _Sub_Region;
		
		private string _GrapeVerietal;
		
		private string _Type;
		
		private System.Nullable<decimal> _SalePrice;
		
		private System.Nullable<decimal> _RegPrice;
		
		private System.Nullable<decimal> _AverageRating;
		
		private System.Nullable<decimal> _UsersRating;
		
		private string _Description;
		
		private int _BottleSize;
		
		private string _LargeImageUrl;
		
		private bool _Liked;
		
		public RetrieveWineDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="Int NOT NULL")]
		public int SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vintage", DbType="Int")]
		public System.Nullable<int> Vintage
		{
			get
			{
				return this._Vintage;
			}
			set
			{
				if ((this._Vintage != value))
				{
					this._Vintage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Sub-Region]", Storage="_Sub_Region", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Sub_Region
		{
			get
			{
				return this._Sub_Region;
			}
			set
			{
				if ((this._Sub_Region != value))
				{
					this._Sub_Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrapeVerietal", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string GrapeVerietal
		{
			get
			{
				return this._GrapeVerietal;
			}
			set
			{
				if ((this._GrapeVerietal != value))
				{
					this._GrapeVerietal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this._Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalePrice", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> SalePrice
		{
			get
			{
				return this._SalePrice;
			}
			set
			{
				if ((this._SalePrice != value))
				{
					this._SalePrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegPrice", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> RegPrice
		{
			get
			{
				return this._RegPrice;
			}
			set
			{
				if ((this._RegPrice != value))
				{
					this._RegPrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AverageRating", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> AverageRating
		{
			get
			{
				return this._AverageRating;
			}
			set
			{
				if ((this._AverageRating != value))
				{
					this._AverageRating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsersRating", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> UsersRating
		{
			get
			{
				return this._UsersRating;
			}
			set
			{
				if ((this._UsersRating != value))
				{
					this._UsersRating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BottleSize", DbType="Int NOT NULL")]
		public int BottleSize
		{
			get
			{
				return this._BottleSize;
			}
			set
			{
				if ((this._BottleSize != value))
				{
					this._BottleSize = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LargeImageUrl", DbType="NVarChar(MAX)")]
		public string LargeImageUrl
		{
			get
			{
				return this._LargeImageUrl;
			}
			set
			{
				if ((this._LargeImageUrl != value))
				{
					this._LargeImageUrl = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Liked", DbType="Bit NOT NULL")]
		public bool Liked
		{
			get
			{
				return this._Liked;
			}
			set
			{
				if ((this._Liked != value))
				{
					this._Liked = value;
				}
			}
		}
	}
	
	public partial class RetrieveAvailableWinesResult
	{
		
		private string _SKU;
		
		private string _Name;
		
		private short _Vintage;
		
		private string _Region;
		
		private string _Country;
		
		private System.Nullable<decimal> _SalePrice;
		
		private System.Nullable<decimal> _RegPrice;
		
		private System.Nullable<decimal> _AverageRating;
		
		private System.Nullable<bool> _Liked;
		
		private string _SmallImageURL;
		
		public RetrieveAvailableWinesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="NVarChar(50)")]
		public string SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(35) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vintage", DbType="SmallInt NOT NULL")]
		public short Vintage
		{
			get
			{
				return this._Vintage;
			}
			set
			{
				if ((this._Vintage != value))
				{
					this._Vintage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(150)")]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalePrice", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> SalePrice
		{
			get
			{
				return this._SalePrice;
			}
			set
			{
				if ((this._SalePrice != value))
				{
					this._SalePrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegPrice", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> RegPrice
		{
			get
			{
				return this._RegPrice;
			}
			set
			{
				if ((this._RegPrice != value))
				{
					this._RegPrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AverageRating", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> AverageRating
		{
			get
			{
				return this._AverageRating;
			}
			set
			{
				if ((this._AverageRating != value))
				{
					this._AverageRating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Liked", DbType="Bit")]
		public System.Nullable<bool> Liked
		{
			get
			{
				return this._Liked;
			}
			set
			{
				if ((this._Liked != value))
				{
					this._Liked = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmallImageURL", DbType="NVarChar(MAX)")]
		public string SmallImageURL
		{
			get
			{
				return this._SmallImageURL;
			}
			set
			{
				if ((this._SmallImageURL != value))
				{
					this._SmallImageURL = value;
				}
			}
		}
	}
	
	public partial class RetrieveRatingsBySKUResult
	{
		
		private int _RatingStars;
		
		private string _RatingText;
		
		private System.DateTime _Date;
		
		private string _UserName;
		
		private System.Nullable<int> _SKU;
		
		private string _Name;
		
		private System.Nullable<int> _Vintage;
		
		private string _Region;
		
		private string _Country;
		
		public RetrieveRatingsBySKUResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingStars", DbType="Int NOT NULL")]
		public int RatingStars
		{
			get
			{
				return this._RatingStars;
			}
			set
			{
				if ((this._RatingStars != value))
				{
					this._RatingStars = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingText", DbType="NVarChar(MAX)")]
		public string RatingText
		{
			get
			{
				return this._RatingText;
			}
			set
			{
				if ((this._RatingText != value))
				{
					this._RatingText = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="Int")]
		public System.Nullable<int> SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vintage", DbType="Int")]
		public System.Nullable<int> Vintage
		{
			get
			{
				return this._Vintage;
			}
			set
			{
				if ((this._Vintage != value))
				{
					this._Vintage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
	}
	
	public partial class AuthenticateUserResult
	{
		
		private int _UserID;
		
		private string _Name;
		
		public AuthenticateUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	public partial class RetrieveReviewsBySKUResult
	{
		
		private int _RatingStars;
		
		private string _RatingText;
		
		private System.DateTime _Date;
		
		private string _UserName;
		
		private System.Nullable<int> _SKU;
		
		private string _Name;
		
		private System.Nullable<int> _Vintage;
		
		private string _Region;
		
		private string _Country;
		
		public RetrieveReviewsBySKUResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingStars", DbType="Int NOT NULL")]
		public int RatingStars
		{
			get
			{
				return this._RatingStars;
			}
			set
			{
				if ((this._RatingStars != value))
				{
					this._RatingStars = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingText", DbType="NVarChar(MAX)")]
		public string RatingText
		{
			get
			{
				return this._RatingText;
			}
			set
			{
				if ((this._RatingText != value))
				{
					this._RatingText = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="Int")]
		public System.Nullable<int> SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vintage", DbType="Int")]
		public System.Nullable<int> Vintage
		{
			get
			{
				return this._Vintage;
			}
			set
			{
				if ((this._Vintage != value))
				{
					this._Vintage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
	}
	
	public partial class RetrieveReviewsByUserIdResult
	{
		
		private int _RatingStars;
		
		private string _RatingText;
		
		private System.DateTime _Date;
		
		private System.Nullable<int> _UserName;
		
		private System.Nullable<int> _SKU;
		
		private string _Name;
		
		private System.Nullable<int> _Vintage;
		
		private string _Region;
		
		private string _Country;
		
		public RetrieveReviewsByUserIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingStars", DbType="Int NOT NULL")]
		public int RatingStars
		{
			get
			{
				return this._RatingStars;
			}
			set
			{
				if ((this._RatingStars != value))
				{
					this._RatingStars = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingText", DbType="NVarChar(MAX)")]
		public string RatingText
		{
			get
			{
				return this._RatingText;
			}
			set
			{
				if ((this._RatingText != value))
				{
					this._RatingText = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="Int")]
		public System.Nullable<int> UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="Int")]
		public System.Nullable<int> SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this._SKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vintage", DbType="Int")]
		public System.Nullable<int> Vintage
		{
			get
			{
				return this._Vintage;
			}
			set
			{
				if ((this._Vintage != value))
				{
					this._Vintage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this._Region = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
