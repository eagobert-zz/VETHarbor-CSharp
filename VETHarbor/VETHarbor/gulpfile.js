/// <binding BeforeBuild='copy-assets' />
"use strict";

var _ = require('lodash'),
    gulp = require('gulp');

gulp.task('copy-assets', function () {
    var assets = {
        js: [
            './node_modules/material-kit/assets/js/bootstrap-material-design.js',
            './node_modules/material-kit/assets/js/material-kit.js'
        ],
        css: ['./node_modules/material-kit/assets/css/material-kit.css'],

<<<<<<< HEAD
        scss: ['./node_modules/material-kit/assets/scss/material-kit.scss'],
        img: ['./node_modules/material-kit/assets/img/kit/**/*.jpg']
=======
        scss: ['./node_modules/material-kit/assets/scss/**/*.scss'],
        img: ['./node_modules/material-kit/assets/img/kit/**/*.jpg',
            './node_modules/material-kit/assets/img/kit/**/*.png']
>>>>>>> parent of 9674fe0... Update files
    };
    _(assets).forEach(function (assets, type) {
        gulp.src(assets).pipe(gulp.dest('./wwwroot/' + type));
    });
});