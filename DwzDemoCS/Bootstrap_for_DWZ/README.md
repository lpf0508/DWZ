# B-JUI #

Bootstrap for DWZ富客户端框架(B-JUI)，基于DWZ富客户端框架修改。

主要针对皮肤，编辑器，表单验证等方面进行了大量修改。

## 兼容性 ##

- IE8.0+, Chrome[最佳], Firefox, Safari。（IE8 未详细测试，估计问题不大，但一些CSS3的效果就不要想了，如圆角、动画什么的）
- 本框架不适用于需要兼容IE6、7的开发者或使用者。
- PS. 未考虑兼容IE6和IE7，一是因为Bootstrap3.2不支持，二是因为目前主流系统已是WIN7(IE8+)，三是带WebKit内核的浏览器大量出现，如360浏览器、搜狗浏览器、百度浏览器等。

## 修改要点 ##

- 引入了前端框架 Bootstrap 3.2，替换了原有皮肤
- 引入了图标字体 Font Awesome 4.1
- 替换了HTML编辑器为 KindEditor 4.1.10
- 替换了表单验证插件为 jquery.validationEngine 2.6.2
- 替换了树形菜单为 zTree 3.5.15
- 替换了拖动排序为 dragsort 0.5.1
- 修改了弹出窗口dialog的多层Modal效果
- 其他：美化select(Bootstrap-select 1.4.2)、checkbox和radio(iCheck 1.0.1)、新增标签(自动完成)[基于BootstrapPlugin - tags修改]
- 上传：不支持HTML5的浏览器默认为(uploadify 3.2.1)，支持HTML5的浏览器使用(Huploadify 2.0，本人已作修改，[新增上传图片预览功能，拖放上传功能]，完美整合本框架

## 本项目测试环境 ##

- 需要使用Apache等WEB服务器搭建一个PHP运行环境
- 纯HTML环境测试，部分功能或不能成功运行（标签、编辑器等）

## 其他 ##

- QQ交流群：232781006
- 在线DEMO：http://www.xknaan.com
