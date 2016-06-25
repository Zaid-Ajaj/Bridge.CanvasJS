﻿(function (globals) {
    "use strict";

    Bridge.define('Bridge.CanvasJS.ChartAlignment', {
        statics: {
            top: 0,
            center: 1,
            bottom: 2
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartAxisType', {
        statics: {
            primary: 0,
            secondary: 1
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartDashType', {
        statics: {
            solid: 0,
            shortDash: 1,
            shortDot: 2,
            shortDashDot: 3,
            shortDashDotDot: 4,
            dot: 5,
            dash: 6,
            dashDot: 7,
            longDash: 8,
            longDashDot: 9,
            longDashDotDot: 10
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartFontStyle', {
        statics: {
            normal: 0,
            italic: 1,
            oblique: 2
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartFontWeight', {
        statics: {
            lighter: 0,
            normal: 1,
            bold: 2,
            bolder: 3
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartIntervalType', {
        statics: {
            number: 0,
            millisecond: 1,
            second: 2,
            minute: 3,
            hour: 4,
            day: 5,
            month: 6,
            year: 7
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartMouseEventArgs', {
        config: {
            properties: {
                X: null,
                Y: null,
                Chart: null,
                DatePoint: null,
                DateSeries: null,
                DatePointIndex: null,
                DateSeriesIndex: null
            }
        }
    });
    
    Bridge.define('Bridge.CanvasJS.ChartType', {
        statics: {
            line: 0,
            column: 1,
            bar: 2,
            spline: 3,
            splineArea: 4,
            stepLine: 5,
            scatter: 6,
            bubble: 7,
            pie: 8,
            doughnut: 9,
            stackedColumn: 10,
            stackedBar: 11,
            stackedArea: 12,
            stackedColumn100: 13,
            stackedBar100: 14,
            stackedArea100: 15
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartValueType', {
        statics: {
            number: 0,
            dateTime: 1
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ChartZoomType', {
        statics: {
            x: 0,
            y: 1,
            xY: 2
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.LabelAlignment', {
        statics: {
            far: 0,
            center: 1,
            near: 2
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.LabelOrientation', {
        statics: {
            horizontal: 0,
            vertical: 1
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.LabelPlacement', {
        statics: {
            inside: 0,
            outside: 1,
            auto: 2
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.MarkerType', {
        statics: {
            none: 0,
            circle: 1,
            square: 2,
            triangle: 3,
            cross: 4
        },
        $enum: true
    });
    
    Bridge.define('Bridge.CanvasJS.ZoomEventType', {
        statics: {
            zoom: 0,
            pan: 1,
            reset: 2
        },
        $enum: true
    });
    
    Bridge.init();
})(this);
