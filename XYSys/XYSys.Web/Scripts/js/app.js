require(['jquery', 'moduleA', 'moduleB'], function ($, moduleA, moduleB) {

});

require.config({
    baseUrl: "Scripts/js",
    path: {
        "jquery": "jquery.min"
    }
});