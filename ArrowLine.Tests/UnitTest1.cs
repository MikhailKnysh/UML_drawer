using ArrowLine.Table;
using NUnit.Framework;
using System.Collections;
using System.Drawing;
using ArrowLine.SelectionObject;
using ArrowLine.Abstract;
using ArrowLine.Arrow;
using System.Collections.Generic;

namespace ArrowLine.Tests
{
    public class ArrowLineTests
    {
        [SetUp]
        public void Setup()
        {
            CollectionFigure.tables = new List<AbstractFigure>();
        }

        [TestCaseSource(typeof(HitTestPoint))]
        public void HitTest_WhenPointNotNull_ShouldReturnBool(AbstractFigure abstractFigure, Selection selectedObject, Point point, bool expected)
        {
            CollectionFigure.tables.Add(abstractFigure);
            bool actual = selectedObject.HitTest(point);
            Assert.AreEqual(expected, actual);
        }

        public class HitTestPoint : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new AgregationEndArrow (FigureType.Arrow){startPoint = new Point(0,0), endPoint = new Point(50,50)},
                    new Selection() { },
                    new Point (0, 0),
                    true
                };
            }
        }

        [TestCaseSource(typeof(HitTestRectangle))]
        public void HitTest_WhenRectangleNotNull_ShouldReturnBool(AbstractFigure abstractFigure, Selection selectObject, Rectangle rectangle, bool expected)
        {
            CollectionFigure.tables.Add(abstractFigure);
            bool actual = selectObject.HitTest(rectangle);
            Assert.AreEqual(expected, actual);
        }

        public class HitTestRectangle : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new AgregationEndArrow(FigureType.Arrow){startPoint = new Point(0,0), endPoint = new Point(50,50)},
                    new Selection() { },
                    new Rectangle (0, 1, 100, 100),
                    true
                };
            }
        }

        [TestCaseSource(typeof(Contain))]
        public void Contain_WhenPointNotNull_ShouldReturnBool(InterfaceTable table, Point point, bool expected)
        {
            CollectionFigure.tables.Add(table);
            bool actual = table.Contain(point);
            Assert.AreEqual(expected, actual);
        }

        public class Contain : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new InterfaceTable(FigureType.Table) {startPoint = new Point(0,0)},
                    new Point (0, 55),
                    true
                };
            }
        }
    }
}