﻿namespace Insight.Utils.Entity
{
    /// <summary>
    /// Json接口返回值
    /// </summary>
    public class Result
    {
        /// <summary>
        /// 结果
        /// </summary>
        public bool Successful { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 错误名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 初始化为未知错误（500）的错误信息
        /// </summary>
        public Result()
        {
            Code = "500";
            Name = "UnknownError";
            Message = "未知错误";
        }

        #region 接口返回信息

        /// <summary>
        /// 返回接口调用成功（200）的成功信息
        /// </summary>
        /// <param name="data">承载的数据（可选）</param>
        /// <returns>JsonResult</returns>
        public void Success(object data = null)
        {
            Successful = true;
            Code = "200";
            Name = "OK";
            Message = "接口调用成功";
            Data = Util.Serialize(data);
        }

        /// <summary>
        /// 返回资源创建成功（201）的成功信息
        /// </summary>
        /// <param name="data">承载的数据（可选）</param>
        /// <returns>JsonResult</returns>
        public void Created(string data = null)
        {
            Successful = true;
            Code = "201";
            Name = "Created";
            Message = "资源创建成功";
            Data = data;
        }

        /// <summary>
        /// 返回用户多地登录（202）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void Multiple()
        {
            Successful = true;
            Code = "202";
            Name = "MultipleLogin";
            Message = "用户已在其他设备登录";
        }

        /// <summary>
        /// 返回无可用内容（204）的成功信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void NoContent()
        {
            Successful = true;
            Code = "204";
            Name = "NoContent";
            Message = "无可用内容";
        }

        /// <summary>
        /// 返回请求参数错误（400）的错误信息
        /// </summary>
        /// <param name="data">承载的数据（可选）</param>
        /// <returns>JsonResult</returns>
        public void BadRequest(string data = null)
        {
            Successful = false;
            Code = "400";
            Name = "BadRequest";
            Message = "请求参数错误";
            Data = data;
        }

        /// <summary>
        /// 返回身份验证失败（401）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void InvalidAuth()
        {
            Successful = false;
            Code = "401";
            Name = "InvalidAuthenticationInfo";
            Message = "提供的身份验证信息不正确";
        }

        /// <summary>
        /// 返回调用接口过于频繁（402）的错误信息
        /// </summary>
        /// <param name="data"></param>
        /// <returns>JsonResult</returns>
        public void TooFrequent(string data)
        {
            Successful = false;
            Code = "402";
            Name = "CallInterfaceTooFrequent";
            Message = "调用接口过于频繁";
            Data = data;
        }

        /// <summary>
        /// 返回用户未取得授权（403）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void Forbidden()
        {
            Successful = false;
            Code = "403";
            Name = "Forbidden";
            Message = "当前用户未取得授权";
        }

        /// <summary>
        /// 返回未找到指定资源（404）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void NotFound()
        {
            Successful = false;
            Code = "404";
            Name = "ResourceNotFound";
            Message = "指定的资源不存在";
        }

        /// <summary>
        /// 返回Guid转换失败（406）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void InvalidGuid()
        {
            Successful = false;
            Code = "406";
            Name = "InvalidGUID";
            Message = "非法的GUID";
        }

        /// <summary>
        /// 返回更新数据失败（407）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void NotUpdate()
        {
            Successful = false;
            Code = "407";
            Name = "DataNotUpdate";
            Message = "未更新任何数据";
        }

        /// <summary>
        /// 返回数据库操作失败（501）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void DataBaseError()
        {
            Successful = false;
            Code = "501";
            Name = "DataBaseError";
            Message = "写入数据失败";
        }

        /// <summary>
        /// 返回数据已存在（502）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void DataAlreadyExists()
        {
            Successful = false;
            Code = "502";
            Name = "DataAlreadyExists";
            Message = "数据已存在";
        }

        /// <summary>
        /// 返回服务不可用（503）的错误信息
        /// </summary>
        /// <returns>JsonResult</returns>
        public void ServiceUnavailable()
        {
            Successful = false;
            Code = "503";
            Name = "ServiceUnavailable";
            Message = "当前服务不可用";
        }

        #endregion

    }
}