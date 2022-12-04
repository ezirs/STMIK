<nav class="navbar navbar-expand-lg bg-light mb-3 rounded mt-2 shadow">
    <div class="container-fluid">
        <a class="navbar-brand" href="#">Baca Berita</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link {{ Request::is('/') ? 'active' : '' }}" href="{{ route('home') }}">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link {{ Request::is('berita') ? 'active' : '' }}" href="{{ route('berita') }}">Berita</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link {{ Request::is('about') ? 'active' : '' }}" href="{{ route('about') }}">About</a>
                </li>
            </ul>
            
            <ul class="navbar-nav ms-auto">
                @guest
                    <li class="nav-item">
                        <a class="nav-link {{ Request::is('login') ? 'active' : '' }} d-flex align-items-center" href="{{ route('login') }}">Login</a>
                    </li>
                    <div class="vr my-auto d-none d-mb-block d-lg-block"></div>
                    <li class="nav-item">
                        <a class="nav-link {{ Request::is('register') ? 'active' : '' }} d-flex align-items-center" href="{{ route('register') }}">Register</a>
                    </li>
                @endguest
                
                @auth
                <li class="nav-item dropdown btn-group">
                    <button type="button" class="btn btn-secondary btn-sm dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
                    Welcome Back, {{ auth()->user()->name }}
                    </button>
                    <ul class="dropdown-menu dropdown-menu-end">
                        <li><a class="dropdown-item active" href="/dashboard">My Dashboard</a></li>
                        <li><hr class="dropdown-divider"></li>
                        <li>
                            <form action="{{ route('logout') }}" method="POST">
                                @csrf
                                <button type="submit" class="dropdown-item">Logout</button>
                            </form>
                        </li>
                    </ul>
                </li>
                @endauth
            </ul>
        </div>
    </div>
</nav>