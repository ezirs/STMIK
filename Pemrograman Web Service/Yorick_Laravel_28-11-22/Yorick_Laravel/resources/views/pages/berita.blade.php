@extends('layouts/app')

@section('container')

<section>
    <div class="row row-cols-2 row-cols-md-2 row-cols-lg-3 mb-3">
        @foreach ($berita as $detail_berita)
            <div class="col mb-2">
                <div class="card">
                    <img src="{{ asset($detail_berita->foto) }}" class="card-img-top" alt="{{ $detail_berita->judul_berita }}">
                    <div class="card-body">
                        <h5 class="card-title">{{ $detail_berita->judul_berita }}</h5>
                        <p class="card-text">{{ $detail_berita->excerpt }}</p>
                        <a href="{{ route('detail_berita', $detail_berita->slug) }}" class="btn btn-primary">Baca sekarang</a>
                    </div>
                </div>
            </div>
        @endforeach
    </div>
    @if(!$berita->count())
        <div class="text-center">
            <h3>Berita belum tersedia</h3>
        </div>
    @endif
</section>

@endsection