# **TS Finish 使用文档**

## 0.更新日志

<u>**软件基于.Net 4.5.2 框架运行**</u>

```
======== TS Finish 10.6.2 更新日志 ======== 
1.增加了适用于PMT表格重建功能的音频编码定义模块。该模块可解决AC-3音频流的流类型被标记为0x06后，无法被主流媒体播放器识别的问题。 
2.修复了在软件中填写大于Int32最大值(2147483647)的ID时，无法被正确处理的问题。

======= TS Finish 10.6.0 更新日志 ======== 
1.进一步优化主处理模块代码，可提升5-10倍以上的处理速度。 
2.修复了重写包计数器功能中的一个严重逻辑错误。
3.修复了提取DDB数据时，可能导致数据无法提取成功的一个标记判定错误。 
4.永久移除了已过时的过滤器功能。

======== TS Finish 10.5.1 更新日志 ========
1.修复了填写16进制ID时，因数据转换错误，从而导致输出的TS流中ID出现误差的问题。

======== TS Finish 10.5.0 更新日志 ======== 
1.新增支持修改指定轨道的PID。推荐您配合PAT/PMT表格重建功能使用。 
2.新增支持RTP流的录制文件输入。此功能可能在未来完全替代现有的"过滤"功能。 
3.新增支持M2TS格式的视频流的文件输入。 
4.新增支持TS包头分析功能。可以快速转换TS包头的十六进制值为完整文字信息。 
5.新增支持重写TS包头加扰标记。如果您将此值设置为非0x00的值，则您需要添加应用标记的PID的流类型。 
6.新增支持单击"输入文件"或"输出文件"标签一键打开对应目录。 
7.开始任务后，若您未选中任何PID，则"使能PID过滤器"选项将自动去使能。优化此项后，将避免因人为疏忽导致输出空文件的现象。 
8.调整功能标签顺序为更常用的顺序。 
9.修改了一些默认设置为更合理的值。 
10.增加国标AVS3编码标记至默认流类型列表，并优化其他默认流类型列表项目的排序。 
11.优化使用"截取"功能实现多任务队列时的文件命名逻辑。 
12.优化少量程序逻辑，避免了一些运行时的程序问题。

======== TS Finish 10.3.2 更新日志 ======== 
1.修复在更新至10.3.1版本的软件后，使用截取功能有概率无法应用正确的结束点的问题。

======== TS Finish 10.3.1 更新日志 ======== 
1.修复使用截取功能并添加多个任务时，可能会导致的输出文件持续膨胀无法自动结束的问题。 
2.修复使用截取功能并添加多个任务时，触发停止操作不生效的问题。 
3.优化部分代码，提升工作效率。

======== TS Finish 10.3.0 更新日志 ======== 
1.优化处理代码，大幅提高处理效率。 
2.增加任务完成提示音。 
3.增加了一些简体中文词条翻译。 
4.细节修改。

======== TS Finish 10.2.3 更新日志 ======== 
1.修复了执行队列任务时，除首个任务外无法正确显示进度的问题。 
2.增加了在一些场景下的提示对话框。若有任务正在执行时，关闭窗口会显示确认提示。

======== TS Finish 10.2.2 更新日志 ========
1.优化重建PMT表格时选择PID的算法。
2.标题栏状态细节变化。

======== TS Finish 10.2.1 更新日志 ========
1.修复使用截取功能时使用时间表达式无效的问题。

======== TS Finish 10.2.0 更新日志 ========
1.增加剩余工作时间估算指示。
2.修复在某些特定情况下，任务完成后再次扫描新的输入文件，会导致扫描出错误PID的问题。

======== TS Finish 10.1.0 更新日志 ======== 
1.增加Download Data Block (DSM-CC)文件块提取功能，可指定ID提取同轴中的DVB广播文件，例如机顶盒固件升级包。

======== TS Finish 10.0.1 更新日志 ========
1.修复"仅提取有效荷载"功能使能后不生效的问题。
2.修正了一个翻译词条。
```




## 1.前期准备（这两个工具仅供参考，不一定非要这两个）

**① 准备FFmpeg(下载地址：[https://github.com/BtbN/FFmpeg-Builds/releases](https://github.com/BtbN/FFmpeg-Builds/releases))**

**② 准备Mediainfo(下载地址：[https://github.com/BtbN/FFmpeg-Builds/releases](https://github.com/BtbN/FFmpeg-Builds/releases))**

**③ 打开主程序，在“输入文件”中 导入要处理的MPEG-2 TS 的视频文件（拖入也可）**

###### ![1](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/1.png)

## 2. "常规" 功能介绍

参考：[https://www.cnblogs.com/shakin/p/3714848.html](https://www.cnblogs.com/shakin/p/3714848.html)

## 3."PID" 功能介绍

 **就是把某个轨道的PID做替换，比如视频PID是0x202，我不喜欢0x202 太2了，我喜欢6666 可以吗 当然可以，把0x202改成6666就行了，当然修改之后 你需要自行考虑重建PAT和PMT的问题。**

## 4.”PAT/PMT“ 功能介绍

参考：[https://www.cnblogs.com/shakin/p/3714848.html](https://www.cnblogs.com/shakin/p/3714848.html)

## 5.“SDT” 功能介绍

**说明：本功能是类似于构建视频的menu菜单，记得勾选 重建SDT表**

① 首先使用 ffmpeg.exe -i "D:\NueXini M3U8 Downloader[2018.07.25]\111\Output\0.ts" 查看信息

![2](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/2.png)

Program值为1，对应着  ***服务ID***

② 使用Mediainfo查看 "D:\NueXini M3U8 Downloader[2018.07.25]\111\Output\0.ts" 信息

![3](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/3.png)

ID值为1，对应着 ***TS流ID***

③ 网络ID是自己随便填的 但建议保留1

！！！接下来就是我们自定义的参数

④ 服务名 与 服务提供商 自己填写 （支持中文输入）

⑤ 服务类型 请选择 : 0x01



以上操作，如图所示(示范)：

![4](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/4.png)

左边不要选择任何选项，选择目标文件，点击开始

⑥ 用Mediainfo看处理后视频文件的效果

![5](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/5.png)



## 6.“截取”功能介绍

① 使用Mediainfo查看视频时长

![6](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/6.png)

② 下面填写时间注意

如想要截取 00:00:00-00:00:02 这个区间

起点应填写：@000000

终点应填写：@000002

总时长：@000003

(总时长填入刚刚查看到的时长，不计毫秒)

(时间格式：@hhmmss)

![7](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/7.png)

③ 点击 “+” 号 添加队列，截取多段按上述操作

④ 最后输出（无损截取，别担心画质丢失）



## 7.“插入”功能介绍

向TS流插入已建立的表格



## 8.“丢弃”功能介绍

俗称 “丢包”，能使完整数据，丢掉部分信息



## 9.“DDB”功能介绍

全称“Download Data Block”

简介：部分机顶盒的固件采用同轴传送，传送数据除TS流，可能会包含着其他文件的数据，如比如 Word，PDF，PPT，Excel，机顶盒固件ZIP 等



![8](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/8.png)

For example : 歌华机顶盒固件的文件ID 如上图所示



## 10.“分析”功能介绍

①  用 Hex(16进制)编辑工具打开视频文件

![9](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/9.png)

② 查看视频文件是0x47420213开头，把420213填入编辑框，即可分析

(注：每188字节是一个ts小包，每个ts小包的前4字节是该包的info)

![10](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/10.png)
