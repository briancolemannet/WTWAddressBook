var gulp = require('gulp');
var del = require('del');

gulp.task('copy', function () {
    del(['./wwwroot/**/*']);
    return gulp.src('./client-app/build/**/*')
        .pipe(gulp.dest('./wwwroot/'));
});

gulp.task('delete', function () {
    return del(['./wwwroot/**/*'])
});

gulp.task('copy:watch', function () {
    gulp.watch('./client-app/build/**/*', ['delete', 'copy']);
});
