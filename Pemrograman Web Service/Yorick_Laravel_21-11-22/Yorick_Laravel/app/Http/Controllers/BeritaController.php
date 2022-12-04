<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Berita;

class BeritaController extends Controller
{
    public function index()
    {
        return view('pages/berita', [
            'berita' => Berita::all()
        ]);
    }

    public function show($detail_berita)
    {
        return view('pages/detil_berita', [
            'db' => Berita::where('slug', $detail_berita)->first()
        ]);
    }
}
