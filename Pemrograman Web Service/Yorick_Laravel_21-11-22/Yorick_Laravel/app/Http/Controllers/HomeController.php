<?php

namespace App\Http\Controllers;

use App\Models\Berita;
use Illuminate\Http\Request;

class HomeController extends Controller
{
    public function home()
    {
        return view('pages/home', [
            'berita' => Berita::all()
        ]);
    }

    public function berita()
    {
        return view('pages/berita');
    }

    public function about()
    {
        return view('pages/about');
    }
}
