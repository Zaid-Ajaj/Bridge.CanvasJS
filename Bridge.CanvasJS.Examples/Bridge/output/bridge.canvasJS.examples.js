(function (globals) {
    "use strict";

    Bridge.define('Bridge.CanvasJS.Examples.App', {
        statics: {
            config: {
                init: function () {
                    Bridge.ready(this.main);
                }
            },
            point$2: function (label, y, x) {
                return { label: label, y: y, x: x };
            },
            point$1: function (label, y) {
                return { label: label, y: y };
            },
            point: function (x, y) {
                return { x: x, y: y };
            },
            main: function () {
    
                Bridge.CanvasJS.Examples.App.columnChart("columnChart").render();
    
    
                // adding new color set for the pie chart
                CanvasJS.addColorSet("greenish", ["green", "darkgreen", "lightgreen"]);
                Bridge.CanvasJS.Examples.App.pieChart("pieChart").render();
    
                Bridge.CanvasJS.Examples.App.sinCurve("sinCurve").render();
            },
            columnChart: function (elementId) {
                return new CanvasJS.Chart("columnChart", { title: { text: "Fruit Sales" }, interactivityEnabled: false, data: [{ type: "column", dataPoints: [Bridge.CanvasJS.Examples.App.point$1("Apple", 10), Bridge.CanvasJS.Examples.App.point$1("Orange", 15), Bridge.CanvasJS.Examples.App.point$1("Banana", 25), Bridge.CanvasJS.Examples.App.point$1("Mango", 30), Bridge.CanvasJS.Examples.App.point$1("Grape", 28)] }] });
            },
            pieChart: function (elementId) {
                return new CanvasJS.Chart("pieChart", { title: { text: "Favorite languages" }, colorSet: "greenish", interactivityEnabled: false, data: [{ type: "pie", dataPoints: [Bridge.CanvasJS.Examples.App.point$1("C#", 40), Bridge.CanvasJS.Examples.App.point$1("F#", 40), Bridge.CanvasJS.Examples.App.point$1("Javascript", 20)] }] });
            },
            sinCurve: function (elementId) {
                // generate points for the curve
                var points = new System.Collections.Generic.List$1(Object)();
                for (var i = 0.0; i < 2.0 * Math.PI; i += 0.1) {
                    points.add(Bridge.CanvasJS.Examples.App.point(i, Math.sin(i)));
                }
    
                return new CanvasJS.Chart("sinCurve", { title: { text: "Sin curve" }, interactivityEnabled: false, data: [{ type: "spline", dataPoints: points.toArray() }], axisY: { gridDashType: "shortDash" } });
            }
        },
        $entryPoint: true
    });
    
    Bridge.init();
})(this);
