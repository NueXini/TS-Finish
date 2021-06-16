# **TS Finish 10.6.0 使用文档**

## 1.前期准备

**① 准备FFmpeg(下载地址：[https://github.com/BtbN/FFmpeg-Builds/releases](https://github.com/BtbN/FFmpeg-Builds/releases))**

**② 准备Mediainfo(下载地址：[https://github.com/BtbN/FFmpeg-Builds/releases](https://github.com/BtbN/FFmpeg-Builds/releases))**

###### **③ 打开主程序，在“输入文件”中 导入要处理的MPEG-2 TS 的视频文件（拖入也可）**

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

⑤ 服务类型

这边推荐亲选择 0x01或0x19的

如果是H265的频道也可以选择0x1F 但习惯上仍然是0x19

0x1f 只建议用在H265上 尽管仍然建议H265使用01或19

!!!总之 为了安全起见：
0x01可以应用于任何ts流



以上操作，如图所示(示范)：

![4](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/4.png)

左边不要选择任何东西，选择目标文件，点击开始

⑥ 用Mediainfo看处理后视频文件的效果

![5](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/5.png)

完工~~！

## 6.“截取”功能介绍

① 使用Mediainfo查看视频时长

![6](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/6.png)

② 下面填写时间注意

比如说你想要截取 00:00:00-00:00:02 这个区间

起点应填写：@000000

终点应填写：@000002

总时长：@000003

(总时长填入刚刚查看到的时长，不计毫秒)

(时间格式：@hh:mm:ss)

![7](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/7.png)

③ 点击 “+” 号 添加队列，截取多段按上述操作

④ 最后输出（无损截取，别担心画质丢失）



## 7.“插入”功能介绍

就是把自己特定的数据包周期性插入要生成的ts流，常用于一些自己重建的表格，本软件目前只支持PAT PMT SDT的重建，而且表格的建立功能也是极其有限的，那么我们可以使用外部已经建立好的表格 插入进去



参数自己适当填写

## 8.“丢弃”功能介绍

目的在于 破坏一个完好的TS流，比如HDC的录像 我给拿过来，然后随机丢弃一些数据包 再发出去，那么不明真相的吃瓜群众就会认为，HDC的录像有问题，总是丢包哦



这个功能也可以用于测试各个ts分析软件的可靠性
比如我丢了一个包 软件没分析出来 那证明这个软件不可靠



ffmpeg是可靠的 因为我丢多少 他就都能分析出来丢弃的位置 满屏黄



参数自己适当填写

## 9.“DDB”功能介绍

全称“Download Data Block”

解释一下：比如北京歌华有线电视 有些机顶盒的固件竟然是用同轴传送的，遵循了国际的DDB规范，这个时候 把完整频点的流文件输入进去 比如你抓固件所在整个频点 抓10个GB的 并填入固件包的 DDB ID （这个就得自己手动分析一下了），同轴里面可能会包含一些有价值的文件，广电把文件进行广播 掺杂在直播电视的信道里，也就是ts流里面 除了能放电视节目 还能放文件数据，比如 word文档，PDF，PPT，Excel，当然塞个固件包zip也是可以的



![8](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/8.png)

歌华机顶盒固件的文件ID如上图所示。
怎么获取的 那是技术人员该干的事
本软件只负责给你按照提供的ID提取出来



## 10.“分析”功能介绍

 用 Hex(16进制)编辑工具打开视频文件

![9](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/9.png)

0x47420213开头，每188字节是一个ts小包，每个ts小包的前4字节是该包的info，你从420213能看出个锤子？看不出来。所以你把420213填进去 你就能明白420213代表什么意思了

![10](https://cdn.jsdelivr.net/gh/NueXini/TS-Finish@10.6.0/TS%20Finish/img/10.png)
