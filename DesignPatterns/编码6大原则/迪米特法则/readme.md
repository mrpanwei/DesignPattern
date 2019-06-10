全称：
    
    Law of Demeter
    
适用：
    
    1.Each unit should have only limited knowledge about other units: only units “closely” related to the current unit
    
    2.Each unit should only talk to its friends; don’t talk to strangers
    
案例：

    平常在零碎的时间里，喜欢看一些书籍，一般都是电子书，现在我们看书的操作是这样的：唤醒手机，打开阅读软件，选择书籍，然后阅读。
    总共 3 个步骤，涉及了 3 样东西：手机、软件、书籍。
    
    书籍和应用对象都在手机上，现实是我们唤醒手机，这时手机是没有书籍的，只有当我们打开阅读软件，才有书籍可以看，没有阅读软件，书籍是看不了的。
    因此，手机和书籍没有一毛钱关系，书籍不应该在手机里面。
    正常的设计是：手机里面有阅读软件，阅读软件里面有书籍，这才符合迪米特法则，
    按定义来说：手机和阅读软件是朋友，阅读软件和书籍是朋友，可是朋友的朋友不是朋友，也就是手机和书籍不是朋友，所以它们不应该有交集，应该离得远远的。
