using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.version.audit.apply
    /// </summary>
    public class AlipayOpenMiniVersionAuditApplyRequest : IAopUploadRequest<AlipayOpenMiniVersionAuditApplyResponse>
    {
        /// <summary>
        /// 小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以通过  https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，长度限制 20~200 个字。 如果不填默认采用当前小程序的应用描述，不可为空。
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称，长度限制 3～30 个字符；仅支持英文和数字。 如果不填默认采用当前小程序应用英文名称，如无默认值则必填，不可为空。
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式仅支持 jpeg,png,jpg,PNG,JPG ,JPEG格式，不支持 bmp,gif,BMP,GIF格式。建议上传像素为180*180 px，logo图片最大 256KB，图片高度与宽度必须一致。 如果不填默认采用当前小程序 logo 图标。
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称，长度限制 3~20 个字符，仅支持包含中文、数字、英文及下划线。 如果不填默认采用当前小程序应用名称，如无默认值则必填，不可为空。
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能，长度限制 10~32个字符。 如果不填默认采用当前小程序应用简介，如无默认值则必填，不可为空。
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号，请选择开发版本执行提交审核操作。
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序投放的端参数。例如投放到支付宝钱包是支付宝端。默认支付宝端。支持： com.alipay.alipaywallet:支付宝端； com.alipay.iot.xpaas：支付宝IoT端。
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// 第五张营业执照照片，不能超过 4MB，最大宽度 2160 px，最大高度 3840 px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序第五张营业执照照片。
        /// </summary>
        public FileItem FifthLicensePic { get; set; }

        /// <summary>
        /// 小程序第五张应用截图，模板实例化的小程序可不传应用截图。 截图大小不能超过 4MB，最大宽度 2160px，最大高度3840px。图片格式仅支持 png,jpg,PNG,JPG 格式。小程序截图数量最小为2，最大为5。
        /// </summary>
        public FileItem FifthScreenShot { get; set; }

        /// <summary>
        /// 第一张营业执照照片，不能超过 4MB，最大宽度 2160 px，最大高度 3840 px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序第一张营业执照照片。
        /// </summary>
        public FileItem FirstLicensePic { get; set; }

        /// <summary>
        /// 小程序第一张应用截图，模板实例化的小程序可不传应用截图。 截图大小不能超过 4MB，最大宽度 2160px，最大高度 3840px。图片格式仅支持 png,jpg,PNG,JPG 格式。小程序截图数量最小为2，最大为5。 
        /// </summary>
        public FileItem FirstScreenShot { get; set; }

        /// <summary>
        /// 第一张特殊资质图片，不能超过4MB，最大宽度 2160px，最大高度3840px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 中是否需要提供特殊资质，如果不填默认采用当前小程序第一张特殊资质。
        /// </summary>
        public FileItem FirstSpecialLicensePic { get; set; }

        /// <summary>
        /// 第四张营业执照照片，不能超过 4MB，最大宽度 2160 px，最大高度 3840 px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序第四张营业执照照片。
        /// </summary>
        public FileItem FourthLicensePic { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，模板实例化的小程序可不传应用截图。 截图大小不能超过 4MB，最大宽度 2160px，最大高度3840px。图片格式仅支持 png,jpg,PNG,JPG 格式。小程序截图数量最小为2，最大为5。
        /// </summary>
        public FileItem FourthScreenShot { get; set; }

        /// <summary>
        /// 营业执照名称，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。  如果不填默认采用当前小程序应用营业执照名称。
        /// </summary>
        public string LicenseName { get; set; }

        /// <summary>
        /// 营业执照号，部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序应用营业执照号。
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 营业执照有效期，格式为 yyyy-MM-dd，9999-12-31表示长期有效。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序营业执照有效期。
        /// </summary>
        public string LicenseValidDate { get; set; }

        /// <summary>
        /// 小程序备注，小程序备注最多500字符。
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query 接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后，若之前已有过审版本，则不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。 注意：个人开发者不得使用企业类目。
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 门头照图片，不能超过 4MB，最大宽度 2160 px，最大高度 3840 px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求上传门头照。 如果不填默认采用当前小程序门头照图片。
        /// </summary>
        public FileItem OutDoorPic { get; set; }

        /// <summary>
        /// 小程序服务区域类型，支持： GLOBAL-全球 CHINA-中国 LOCATION-指定区域
        /// </summary>
        public string RegionType { get; set; }

        /// <summary>
        /// 第二张营业执照照片，不能超过 4MB，最大宽度 2160 px，最大高度 3840 px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序第二张营业执照照片。
        /// </summary>
        public FileItem SecondLicensePic { get; set; }

        /// <summary>
        /// 小程序第二张应用截图，模板实例化的小程序可不传应用截图。 截图大小不能超过 4MB，最大宽度 2160px，最大高度3840px。图片格式仅支持 png,jpg,PNG,JPG 格式。小程序截图数量最小为2，最大为5。
        /// </summary>
        public FileItem SecondScreenShot { get; set; }

        /// <summary>
        /// 第二张特殊资质图片文件，不能超过4MB，最大宽度 2160px，最大高度3840px，图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 中是否需要提供特殊资质，如果不填默认采用当前小程序第二张特殊资质图片。
        /// </summary>
        public FileItem SecondSpecialLicensePic { get; set; }

        /// <summary>
        /// 小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱，小程序客服电话和邮箱至少输入一个。 注意：2021年7月1日后，该字段将逐步灰度为可选字段，请按可选开发。 
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话，长度限制5~30个字符，仅支持包含数字和-。如果不填默认采用当前小程序的应用客服电话，小程序客服电话和邮箱至少输入一个。 注意：2021年7月1日后，该字段将逐步灰度为必填字段，请按必填开发。
        /// </summary>
        public string ServicePhone { get; set; }

        /// <summary>
        /// 省市区信息。当region_type为LOCATION或传入city_code时，province_code不能为空；填写area_code时，province_code和city_code不能为空。只填province_code则全选该省；填写province_code和city_code则全选该市，以此类推。省市区code参见https://gw.alipayobjects.com/os/bmw-prod/0aab0319-13de-42b9-85cf-13877a5f78ed.xlsx
        /// </summary>
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 测试账号，是否需要填写请参见https://opendocs.alipay.com/mini/operation/standard/case/akxg6r#3.%20%E6%B5%8B%E8%AF%95%E5%86%85%E5%AE%B9%E6%8F%90%E4%BA%A4%E4%B8%8D%E5%AE%8C%E6%95%B4
        /// </summary>
        public string TestAccout { get; set; }

        /// <summary>
        /// 测试附件，用于上传测试报告和测试录屏，请上传10M以内附件，支持格式zip，rar。是否需要填写请参见:https://opendocs.alipay.com/mini/operation/standard/case/akxg6r#3.%20%E6%B5%8B%E8%AF%95%E5%86%85%E5%AE%B9%E6%8F%90%E4%BA%A4%E4%B8%8D%E5%AE%8C%E6%95%B4
        /// </summary>
        public FileItem TestFileName { get; set; }

        /// <summary>
        /// 测试账号密码
        /// </summary>
        public string TestPassword { get; set; }

        /// <summary>
        /// 第三张营业执照照片，不能超过 4MB，最大宽度 2160 px，最大高度 3840 px。图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 要求填写营业执照信息。 如果不填默认采用当前小程序第三张营业执照照片。
        /// </summary>
        public FileItem ThirdLicensePic { get; set; }

        /// <summary>
        /// 小程序第三张应用截图，模板实例化的小程序可不传应用截图。 截图大小不能超过 4MB，最大宽度 2160px，最大高度 3840px。图片格式仅支持 png,jpg,PNG,JPG 格式。小程序截图数量最小为2，最大为5。
        /// </summary>
        public FileItem ThirdScreenShot { get; set; }

        /// <summary>
        /// 第三张特殊资质图片文件，不能超过4MB，最大宽度 2160px，最大高度3840px，图片格式仅支持 png,jpg,PNG,JPG 格式。 部分小程序类目需要提交，参照https://opendocs.alipay.com/mini/operation/material 中是否需要提供特殊资质，如果不填默认采用当前小程序第三张特殊资质。
        /// </summary>
        public FileItem ThirdSpecialLicensePic { get; set; }

        /// <summary>
        /// 小程序版本描述，30-500个字符。
        /// </summary>
        public string VersionDesc { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

    	 public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

		public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.mini.version.audit.apply";
        }

        public void PutOtherTextParam(string key, string value) 
        {
            if(this.udfParams == null) 
            {
                this.udfParams = new Dictionary<string, string>();
            }
            this.udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("app_category_ids", this.AppCategoryIds);
            parameters.Add("app_desc", this.AppDesc);
            parameters.Add("app_english_name", this.AppEnglishName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_slogan", this.AppSlogan);
            parameters.Add("app_version", this.AppVersion);
            parameters.Add("bundle_id", this.BundleId);
            parameters.Add("license_name", this.LicenseName);
            parameters.Add("license_no", this.LicenseNo);
            parameters.Add("license_valid_date", this.LicenseValidDate);
            parameters.Add("memo", this.Memo);
            parameters.Add("mini_category_ids", this.MiniCategoryIds);
            parameters.Add("region_type", this.RegionType);
            parameters.Add("service_email", this.ServiceEmail);
            parameters.Add("service_phone", this.ServicePhone);
            parameters.Add("service_region_info", this.ServiceRegionInfo);
            parameters.Add("test_accout", this.TestAccout);
            parameters.Add("test_password", this.TestPassword);
            parameters.Add("version_desc", this.VersionDesc);
            if(udfParams != null) 
            {
                parameters.AddAll(this.udfParams);
            }
            return parameters;
        }
		
		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("app_logo", this.AppLogo);
            parameters.Add("fifth_license_pic", this.FifthLicensePic);
            parameters.Add("fifth_screen_shot", this.FifthScreenShot);
            parameters.Add("first_license_pic", this.FirstLicensePic);
            parameters.Add("first_screen_shot", this.FirstScreenShot);
            parameters.Add("first_special_license_pic", this.FirstSpecialLicensePic);
            parameters.Add("fourth_license_pic", this.FourthLicensePic);
            parameters.Add("fourth_screen_shot", this.FourthScreenShot);
            parameters.Add("out_door_pic", this.OutDoorPic);
            parameters.Add("second_license_pic", this.SecondLicensePic);
            parameters.Add("second_screen_shot", this.SecondScreenShot);
            parameters.Add("second_special_license_pic", this.SecondSpecialLicensePic);
            parameters.Add("test_file_name", this.TestFileName);
            parameters.Add("third_license_pic", this.ThirdLicensePic);
            parameters.Add("third_screen_shot", this.ThirdScreenShot);
            parameters.Add("third_special_license_pic", this.ThirdSpecialLicensePic);
            return parameters;
        }

        #endregion
    }
}
