# R-Instat

<!-- hy-mt2-i18n:start -->
[English](./README.md) | **中文** | [日本語](./README_ja.md) | [Español](./README_es.md)
<!-- hy-mt2-i18n:end -->


R-Instat是一款基于R语言开发的免费、菜单驱动型统计软件。它旨在充分利用R统计系统的强大功能，同时通过其菜单和对话框式界面，实现与其他传统点选式统计软件一样简单的使用体验。

## 下载

最新版本可在 https://r-instat.org/ 获取，该页面还提供了安装说明及入门指南。目前 R-Instat 仅为 Windows 系统专用软件，安装文件中已包含所有前置条件，包括所需的 R 包。

## 背景介绍

### 非洲数据计划

R-Instat是在[非洲数据计划](http://africdata.org/)（ADI）框架下开发的首款产品，该合作项目旨在提升整个非洲地区的统计能力与数据素养。虽然非洲数据计划的总目标并不仅限于开发这款软件，但我们认为R-Instat是实现这一变革的重要第一步。

推动 R-Instat 开发的[众筹活动](https://chuffed.org/project/africdatainitiative)中介绍了该软件最初的目标用户群体。在活动中我们指出，现有的统计软件存在不足，人们需要易于使用、免费且开源，并能倡导良好统计实践的统计软件。如需了解更多详情，请观看我们的3分钟宣传视频：

[![非洲数据计划宣传视频](http://img.youtube.com/vi/0_YAjLBVPrI/0.jpg)](http://www.youtube.com/watch?v=0_YAjLBVPrI)

### R 语言

R-Instat可被视为通往[R统计系统](https://www.r-project.org/)的接口。我们仔细挑选了所使用的R包，但有时为了实现R-Instat的功能，不得不偏离“标准”的R代码。这些R代码以及对应的包名都可以在R-Instat的日志窗口中查看。对于R用户而言，这一功能也可能很有用，比如帮助他们了解R-Instat的图形对话框所依赖的[ggplot2](http://ggplot2.org/)包的语法。对于那些希望转而管理和编写R脚本的用户，我们也方便了他们在RStudio脚本窗口中打开日志文件。

### Instat

“R-Instat”中的“Instat”指的是一种[软件](https://www.reading.ac.uk/ssc/resourcepage/instat.php)，它最初于20世纪70年代开发，其目标与受众与R-Instat相似，而R-Instat的许多设计理念也受到了Instat的启发。Instat曾设有用于分析气候数据的专用菜单，R-Instat延续了这一传统，同时还新增了用于分析公共采购数据的专用菜单。使用过Instat的用户会发现R-Instat的界面十分熟悉。

## 贡献方式

我们欢迎任何希望以多种方式为我们项目做出贡献的人士：

- 我们欢迎大家提交错误报告，可通过我们的[问题页面](https://github.com/africanmathsinitiative/R-Instat/issues)进行提交。
- 如有更一般的反馈、建议或意见，请发送邮件至 r-instat (at) africanmathsinitiative.net。
- 若想为项目开发做出贡献，请参阅我们的贡献指南文档（暂未发布）。

## 许可证

R-Instat 是一款遵循 GNU 通用公共许可证第 3 版授权的免费软件。
