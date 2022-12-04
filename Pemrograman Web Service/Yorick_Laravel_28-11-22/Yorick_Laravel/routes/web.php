<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\LoginController;
use App\Http\Controllers\BeritaController;
use App\Http\Controllers\RegisterController;
use App\Http\Controllers\DashboardController;
use App\Http\Controllers\DashboardBeritaController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

// Route::get('/', function () {
//     return view('welcome');
// });



Route::controller(HomeController::class)->group(function () {
    Route::get('/', 'home')->name('home');
    Route::get('/about', 'about')->name('about');
});

Route::controller(BeritaController::class)->group(function () {
    Route::get('/berita', 'index')->name('berita');
    Route::get('/berita/{detail_berita:slug}', 'show')->name('detail_berita');
});

Route::middleware('guest')->controller(LoginController::class)->group(function () {
    Route::get('/login', 'index')->name('login');
    Route::post('/login', 'authenticate')->name('postLogin');
});

Route::post('/logout', [LoginController::class ,'logout'])->name('logout');

Route::middleware('guest')->controller(RegisterController::class)->group(function () {
    Route::get('/register', 'index')->name('register');
    Route::post('/register', 'store')->name('postRegister');
});
Route::prefix('/dashboard')->group(function () {
    Route::get('/', [DashboardController::class, 'index'])->name('dashboard')->middleware('auth');
    Route::prefix('/berita')->group(function () {
        Route::get('/', [DashboardBeritaController::class, 'index'])->name('dashboardBerita')->middleware('auth');
        Route::post('/', [DashboardBeritaController::class, 'store'])->name('dashboardBeritaPost')->middleware('auth');
        Route::get('/create', [DashboardBeritaController::class, 'create'])->name('dashboardBeritaCreate')->middleware('auth');
        Route::get('/checkSlug', [DashboardBeritaController::class, 'checkSlug'])->name('dashboardBeritaCheckSlug')->middleware('auth');
        Route::get('/{slug}', [DashboardBeritaController::class, 'show'])->name('dashboardBeritaShow')->middleware('auth');
        Route::get('/{slug}/edit', [DashboardBeritaController::class, 'edit'])->name('dashboardBeritaEdit')->middleware('auth');
        Route::delete('/{slug}', [DashboardBeritaController::class, 'destroy'])->name('dashboardBeritaDelete')->middleware('auth');
    });
    
});




