
1.parameters: [FromUri] and [FromBody]
  note: [FromBody]只能有一个
2.DataFormat<MIME Type>:application/json, text/html, image/jpeg, text/xml

  Content-Type:  传递参数
  Accept:  接收返回值

3.Global.asax -> configuration/**ApiConfig.cs -> Controller/**Controller(inherit from ApiController)

4.Tutorial test api:
   http://localhost:63324/student




reference: https://www.tutorialsteacher.com/webapi/web-api-tutorials
