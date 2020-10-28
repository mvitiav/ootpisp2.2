using PlugBase;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    public class FakerConfig
    {


        public List<Generator> generators = new List<Generator>();
        //public Dictionary<object, Type> dictionary = new Dictionary<object, Type>();
        public Dictionary<ParameterInfo, Type> dictionary1 = new Dictionary<ParameterInfo, Type>();
        public Dictionary<PropertyInfo, Type> dictionary2 = new Dictionary<PropertyInfo, Type>();
        public Dictionary<FieldInfo, Type> dictionary3 = new Dictionary<FieldInfo, Type>();

        public bool checkIfPlugged(PropertyInfo o) {
            // return ( ()&&());
           return dictionary2.ContainsKey(o);
            
            //return false;
        }
        public bool checkIfPlugged(FieldInfo o)
        {
            // return ( ()&&());
            return dictionary3.ContainsKey(o);

            //return false;
        }
        public bool checkIfPlugged(ParameterInfo o)
        {
            // return ( ()&&());
            return dictionary1.ContainsKey(o);

            //return false;
        }
      

        public void addGen(Generator g) {
            if (!generators.Contains(g))
            generators.Add(g);
        }

        public Generator getGen(Type t) { 
            foreach (Generator gen in generators) {
                if (gen.GetType().Equals(t)) { return gen; } ;
            }            
            return null; }


        public PropertyInfo GetPropertyInfo<TSource, TProperty>(
    TSource source,
    //Expression<Func<TSource, TProperty>> propertyLambda)
    Expression<Func<TSource, TProperty>> propertyLambda)
        {
            Type type = typeof(TSource);

            MemberExpression member = propertyLambda.Body as MemberExpression;
            if (member == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    propertyLambda.ToString()));

            PropertyInfo propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a field, not a property.",
                    propertyLambda.ToString()));

            if (type != propInfo.ReflectedType &&
                !type.IsSubclassOf(propInfo.ReflectedType))
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a property that is not from type {1}.",
                    propertyLambda.ToString(),
                    type));

            return propInfo;
        }

        public FieldInfo GetFieldInfo<TSource, TProperty>(
TSource source,
//Expression<Func<TSource, TProperty>> propertyLambda)
Expression<Func<TSource, TProperty>> propertyLambda)
        {
            Type type = typeof(TSource);

            MemberExpression member = propertyLambda.Body as MemberExpression;
            if (member == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    propertyLambda.ToString()));

            FieldInfo FieldInfo = member.Member as FieldInfo;
            if (FieldInfo != null) { 
                //    throw new ArgumentException(string.Format(
                //        "Expression '{0}' refers to a field, not a property.",
                //        propertyLambda.ToString()));

                //if (type != propInfo.ReflectedType &&
                //    !type.IsSubclassOf(propInfo.ReflectedType))
                //    throw new ArgumentException(string.Format(
                //        "Expression '{0}' refers to a property that is not from type {1}.",
                //        propertyLambda.ToString(),
                //        type));

                return FieldInfo; }
            else { throw new ArgumentException("not a fielddinfo"); }
        }

        static Expression<Func<TInput, object>> AddBox<TInput, TOutput>
       (Expression<Func<TInput, TOutput>> expression)
        {
            // Add the boxing operation, but get a weakly typed expression
            Expression converted = Expression.Convert
                 (expression.Body, typeof(object));
            // Use Expression.Lambda to get back to strong typing
            return Expression.Lambda<Func<TInput, object>>
                 (converted, expression.Parameters);
        }

        public static LambdaExpression StripConvert<T>(Expression<Func<T, object>> source)
        {
            Expression result = source.Body;
            // use a loop in case there are nested Convert expressions for some crazy reason
            while (((result.NodeType == ExpressionType.Convert)
                       || (result.NodeType == ExpressionType.ConvertChecked))
                   && (result.Type == typeof(object)))
            {
                result = ((UnaryExpression)result).Operand;
            }
            return Expression.Lambda(result, source.Parameters);
        }

        //public void add<T,T2,G>(Expression<Func<T,object>> expr)
        public void add<T>(Generator G,Expression<Func<T,object>> expr2)
        {
           // Func<T, object> expr2 = expr.Compile();
            //var expr = DynamicExpression.ParseLambda(new[] { typeof(T) }, typeof(object), expr2);

            //var expr2 = (Expression<Func<T, object>>)StripConvert(expr3);
            var expr = StripConvert(expr2);
           
         //   var expr = AddBox(expr2);


            MemberExpression member = expr.Body as MemberExpression;

            

                if (member == null)
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    expr.ToString()));

            PropertyInfo propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
            {
                dictionary3.Add(member.Member as FieldInfo, G.GetType());
                //check if 0
            }
            else {
                dictionary2.Add(propInfo, G.GetType());
            }
            //    throw new ArgumentException(string.Format(
            //        "Expression '{0}' refers to a field, not a property.",
            //        expr.ToString()));

            //if (typeof(T) != propInfo.ReflectedType &&
            //    !typeof(T).IsSubclassOf(propInfo.ReflectedType))
            //    throw new ArgumentException(string.Format(
            //        "Expression '{0}' refers to a property that is not from type {1}.",
            //        expr.ToString(),
            //        typeof(T)));

            


         
         
            
            
            
            //check if it can master this type
           // Console.WriteLine(GetPropertyInfo(,expr));



            //    ParameterExpression param = (ParameterExpression)expr.Parameters[0];
            //    BinaryExpression operation = (BinaryExpression)expr.Body;
            ////    ParameterExpression left = (ParameterExpression)expr.;
            // //   ConstantExpression right = (ConstantExpression)expr.Right;
            //    Console.WriteLine("Decomposed expression: {0} => {1} {2} {3}",
            //          param.Name, left.Name, operation.NodeType, right.Value);
            //Expression.Call(expr,);
            
           
        }


    }
}
