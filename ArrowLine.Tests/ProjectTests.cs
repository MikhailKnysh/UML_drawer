using UMLDrawer.Table;
using NUnit.Framework;
using System.Collections;
using System.Drawing;
using UMLDrawer.SelectionObject;
using UMLDrawer.Abstract;
using UMLDrawer.Arrow;
using System.Collections.Generic;
using UMlDrawer.Abstract;

namespace UMLDrawer.Tests
{
    public class ArrowLineTests
    {
        [SetUp]
        public void Setup()
        {
            CollectionFigure.collectionFigures = new List<AbstractFigure>();
        }

        [TestCaseSource(typeof(HitObjectAreaWithPoint))]
        public void HitObjectArea_WhenPointNotNull_ShouldReturnBool(AbstractFigure abstractFigure, Selection selectedObject, Point point, bool expected)
        {
            CollectionFigure.collectionFigures.Add(abstractFigure);

            bool actual = selectedObject.HitObjectArea(point);

            Assert.AreEqual(expected, actual);
        }

        public class HitObjectAreaWithPoint : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new AggregationEndArrow (FigureType.Arrow) {StartPoint = new Point(0, 0), EndPoint = new Point(50, 50)},
                    new Selection(),
                    new Point(0, 0),
                    true
                };
                yield return new object[]
                {
                    new InterfaceTable (FigureType.Table) {StartPoint = new Point(10, 10)},
                    new Selection(),
                    new Point(70, 20),
                    true
                };
                yield return new object[]
               {
                    new CompositionEndArrow (FigureType.Arrow) {StartPoint = new Point(0, 0), EndPoint = new Point(50, 50)},
                    new Selection(),
                    new Point(0, 0),
                    true
                };
                yield return new object[]
               {
                    new ClassTable (FigureType.Table) {StartPoint = new Point(10, 10)},
                    new Selection(),
                    new Point(60, 20),
                    true
                };
                yield return new object[]
                {
                    new InheritanceArrow (FigureType.Arrow) {StartPoint = new Point(0, 0), EndPoint = new Point(50, 50)},
                    new Selection(),
                    new Point(0, 0),
                    true
                };
            }
        }

        [TestCaseSource(typeof(HitObjectAreaWithRectangle))]
        public void HitObjectArea_WhenRectangleNotNull_ShouldReturnBool(AbstractFigure abstractFigure, Selection selectObject, Rectangle rectangle, bool expected)
        {
            CollectionFigure.collectionFigures.Add(abstractFigure);

            bool actual = selectObject.HitObjectArea(rectangle);

            Assert.AreEqual(expected, actual);
        }

        public class HitObjectAreaWithRectangle : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new StackTable (FigureType.Table) {StartPoint = new Point(20,20)},
                    new Selection(),
                    new Rectangle (10, 10, 300, 300),
                    true
                };
                yield return new object[]
                {
                    new InterfaceTable (FigureType.Table) {StartPoint = new Point(10,10)},
                    new Selection(),
                    new Rectangle (10, 10, 500, 500),
                    true
                };
                yield return new object[]
                {
                    new CompositionEndArrow (FigureType.Arrow) {StartPoint = new Point(60,70), EndPoint = new Point(150,80)},
                    new Selection(),
                    new Rectangle (10, 10, 100, 100),
                    true
                };
                yield return new object[]
                {
                    new ClassTable (FigureType.Table) {StartPoint = new Point(70,70)},
                    new Selection(),
                    new Rectangle (60, 30, 700, 300),
                    true
                };
                yield return new object[]
                {
                    new InheritanceArrow (FigureType.Arrow) {StartPoint = new Point(60,200), EndPoint = new Point(170,150)},
                    new Selection(),
                    new Rectangle (60, 300, 100, 300),
                    false
                };
            }
        }

        [TestCaseSource(typeof(Contains))]
        public void Contains_WhenPointNotNull_ShouldReturnBool(AbstractTable table, AbstractFigure arrow, bool expected)
        {
            CollectionFigure.collectionFigures.Add(table);

            bool actual = table.Contains(arrow.StartPoint);

            Assert.AreEqual(expected, actual);
        }

        public class Contains : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new InterfaceTable(FigureType.Table) {StartPoint = new Point(10, 10)},
                    new AggregationEndArrow(FigureType.Arrow) {StartPoint = new Point(70, 9), EndPoint = new Point(150,150)},
                    true
                };
                yield return new object[]
                {
                    new InterfaceTable(FigureType.Table) {StartPoint = new Point(10, 10)},
                    new AggregationEndArrow(FigureType.Arrow) {StartPoint = new Point(9, 29), EndPoint = new Point(150,150)},
                    true
                };
                yield return new object[]
                {
                    new InterfaceTable(FigureType.Table) {StartPoint = new Point(10, 10)},
                    new AggregationEndArrow(FigureType.Arrow) {StartPoint = new Point(151, 45), EndPoint = new Point(200,2000)},
                    true
                };
                yield return new object[]
                {
                    new InterfaceTable(FigureType.Table) {StartPoint = new Point(10, 10)},
                    new AggregationEndArrow(FigureType.Arrow) {StartPoint = new Point(70, 71), EndPoint = new Point(150,150)},
                    true
                };
            }
        }

        [TestCaseSource(typeof(MoveObject))]
        public void Move_WhenPointNotNull_ShouldNewPointLocation(AbstractFigure abstractFigure, int deltaX, int deltaY, Point expected)
        {
            CollectionFigure.collectionFigures.Add(abstractFigure);

            abstractFigure.Move(deltaX, deltaY);
            Point actual = new Point(deltaX, deltaY);

            Assert.AreEqual(expected, actual);
        }

        public class MoveObject : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]
                {
                    new InterfaceTable(FigureType.Table) {StartPoint = new Point(10,10)},
                    (int) 80,
                    (int) 80,
                    new Point(80, 80)
                };
                yield return new object[]
                {
                    new InheritanceArrow(FigureType.Arrow) {StartPoint = new Point(100, 100), EndPoint = new Point(100, 100)},
                    (int) 50,
                    (int) 50,
                    new Point(50, 50)
                };
                yield return new object[]
                {
                    new CompositionStartArrow(FigureType.Arrow) {StartPoint = new Point(10,10), EndPoint = new Point(100, 100)},
                    (int) 5,
                    (int) 5,
                    new Point(5, 5)
                };
                yield return new object[]
                {
                    new ClassTable(FigureType.Table) {StartPoint = new Point(10,10)},
                    (int) 80,
                    (int) 80,
                    new Point(80, 80)
                };
                yield return new object[]
                {
                    new AggregationStartArrow(FigureType.Arrow) {StartPoint = new Point(10, 10),EndPoint = new Point(100, 100)},
                    (int) 80,
                    (int) 80,
                    new Point(80, 80)
                };
            }
        }
    }
}