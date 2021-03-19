# UnityTool-SPlayerPrefs
Unity Save Data In Loacl<br>
一个本地数据储存的工具<br>
以创建class的方式，进行数据的读写，方便了使用<br>
本质还是使用PlayerPrefs的方式进行读写<br>
支持int，string，float，还扩展了结构体和链表结构<br>
例子：<br>
public class PrefsData : SStruct<br>
{<br>
public PrefsData(string key)<br>
{<br>
Init(new UnityStorage(), key);<br>
}<br>
[SDef(-1)]<br>
public SInt id;<br>
public SString name;<br>
public Sfloat time;<br>
}<br>
