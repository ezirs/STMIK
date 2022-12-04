@extends('pages.dashboard.main')
@section('container')

    <div class="card-body">
        <div class="card card-primary">
            <div class="card-header">
                <h3 class="card-title">Tambah Berita</h3>
            </div>
            <form method="POST" action="{{ route('dashboardBeritaPost') }}">
                @csrf
                <div class="card-body">
                    <div class="form-group">
                        <label for="judul_berita" class="form-label">Judul Berita</label>
                        <input type="text" class="form-control @error('judul_berita') is-invalid @enderror" name="judul_berita" id="judul_berita" placeholder="Judul Berita">
                        @error('judul_berita')
                            <div class="invalid-feedback">
                                {{ $message }}
                            </div>
                        @enderror
                    </div>
                    <div class="form-group">
                        <label for="slug" class="form-label">Slug</label>
                        <input type="text" class="form-control @error('slug') is-invalid @enderror" name="slug" id="slug" placeholder="Slug">
                    </div>
                    <div class="form-group">
                        <label for="kategori_id" class="form-label">Kategori</label>
                        <select class="custom-select rounded-0" id="kategori_id" name="kategori_id">
                            @foreach($kategori as $kategori)
                                <option value="{{ $kategori->id }}">{{ $kategori->nama }}</option>
                            @endforeach
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="isi_berita" class="form-label">Isi Berita</label>
                        @error('isi_berita')
                            <div class="invalid-feedback">
                                {{ $message }}
                            </div>
                        @enderror
                        <textarea id="summernote" name="isi_berita"></textarea>
                    </div>
                </div>
                <div class="card-footer">
                    <button type="submit" class="btn btn-primary">Submit</button>
                </div>
            </form>
        </div>
    </div>
    <script>
        const judul_berita = document.querySelector("#judul_berita");
        const url = "{{ route('dashboardBeritaCheckSlug') }}";
        const slug = document.querySelector("#slug");
        judul_berita.addEventListener('change', function () {
            fetch(url + "?judul_berita=" + judul_berita.value)
            .then(response => response.json())
            .then(data => slug.value = data.slug)
        })
    </script>
@endsection