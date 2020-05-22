using System;
using System.Reflection;


namespace TestFramework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NTestClassAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class NTestMethodAttribute : Attribute
    {
    }
    //Run all attributed classes and methods.
    public class TestRunner
    {
        public static void Run()
        {
            Type[] types = Assembly.GetCallingAssembly().GetTypes();
            foreach (Type t in types)
            {
                if (GetAttributedMembers.GetClasses(t))
                {
                    MethodInfo[] methods = t.GetMethods();
                    foreach (MethodInfo methodInfo in methods)
                    {
                        if (GetAttributedMembers.Get_Methods(methodInfo))
                             methodInfo.Invoke(Activator.CreateInstance(t), null);
                    }

                }
            }
        }
    }

    public static class GetAttributedMembers
    {
        //Check attributed Classes.
        public static bool GetClasses(Type type)
        {
            Attribute[] attrs;
            attrs = Attribute.GetCustomAttributes(type);

            foreach (Attribute attr in attrs)
            {
                if (attr is NTestClassAttribute)
                    return true;
                
            }
            return false;
        }
        //Check attributed methods.
        public static bool Get_Methods(MemberInfo methodInfo)
        {
           
                Attribute attributes = methodInfo.GetCustomAttribute(typeof(NTestMethodAttribute), false);

                 var attribute = (NTestMethodAttribute)attributes;

                if (attribute is NTestMethodAttribute)
                
                    return true ;
                else return false ;
            }
        }
    //Simple implementation of Assert Class
        public class Assert<T> where T : IComparable<T>
        {
            public static bool AreEqual(T expected, T result)
            {
                if (expected.CompareTo(result) == 0)
                    return true;
                else return false;
            }

            public static bool IsTrue(bool condition)
            {
                if (condition)
                    return true;
                else
                    return false;
            }

            public static bool IsFalse(bool condition)
            {
                if (condition)
                    return false;
                else
                    return true;
            }
        }
    }