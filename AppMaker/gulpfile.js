/// <binding BeforeBuild='compile-less' />


var gulp = require('gulp');
var gulpLess = require('gulp-less');
gulp.task('compile-less', function () {
    gulp.src('./wwwroot/lib/bootstrap/less/bootstrap.less')
        .pipe(gulpLess()).pipe(gulp.dest('./wwwroot/css'));
    gulp.src('./wwwroot/lib/bootstrap/fonts/**.*')
        .pipe(gulp.dest('./wwwroot/fonts'));
});

