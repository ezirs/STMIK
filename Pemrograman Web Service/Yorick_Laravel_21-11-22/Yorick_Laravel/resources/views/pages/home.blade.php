@extends('layouts/app')

@section('container')
<section>
    <div class="mb-5">
        <div class="card mb-3 w-100">
            <div class="row g-0 p-2">
                <div class="col-md-4 d-flex align-items-center">
                    <img src="{{ asset('img/OIP.jpg') }}" class="img-fluid rounded-start" alt="img">
                </div>
                <div class="col-md-8">
                    <div class="card-body">
                        <h5 class="card-title">Google Hilang</h5>
                        <p class="card-text">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Omnis ut, quae fugit, rem possimus natus sequi eligendi ducimus porro quod sed in cupiditate suscipit nulla rerum vero. Dignissimos, doloremque ratione?</p>
                        <div class="mb-2">
                            <button class="btn btn-outline-primary btn-sm col-3">Baca</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<hr class="col-3 col-md-2 mb-5">

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
</section>

@endsection