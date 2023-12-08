import Home from './Pages/Home'
import GoogleLogin from './Pages/GoogleLogin'

const AppRoutes = [
  {
    index: true,
    element: <Home />,
  },
  {
    path: "/Login",
    element: <GoogleLogin />,
  },
];

export default AppRoutes;
