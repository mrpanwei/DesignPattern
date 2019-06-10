全称：
    
    Liskov Substitution Principle
    
适用：

    1.If for each object o1 of type S there is an object o2 of type T such that for all programs P defined in terms of T,the behavior of P is unchanged when o1 is substituted for o2 then S is a subtype of T.
    
    2.Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.
    
    所有引用基类的地方必须能透明地使用其子类的对象
   
案例：

    假如S能胜任P干的所有事情，那P就是S的父亲，也就是儿子要会父亲的所有能活，儿子活得再烂也要有父亲的水平。
    里氏替换原则定义了什么是父子，还有一点要注意的，就是儿子不能在父亲会的技能上搞“创新”。
