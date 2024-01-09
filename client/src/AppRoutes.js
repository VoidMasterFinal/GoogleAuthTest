import Home from './Pages/Home'
import GoogleLogin from './Pages/GoogleLogin'
import UserHome from './Pages/UserHome'
import Register from './Pages/Register'

const AppRoutes = [
  {
    index: true,
    element: <Home />,
  },
  {
    path: "/GoogleLogin",
    element: <GoogleLogin />,
  },
  {
    path: "/UserHome",
    element: <UserHome />,
  },
  {
    path: "/Register",
    element: <Register />,
  }
];

export default AppRoutes;
