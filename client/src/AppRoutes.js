import Home from './Pages/Home'
import GoogleLogin from './Pages/GoogleLogin'
import UserHome from './Pages/UserHome'
import Register from './Pages/Register'
import Onderzoeken from './Pages/Onderzoeken'
import GedetaileerdOnderzoek from './Pages/GedetaileerdOnderzoek'
import Gegevens from './Pages/Gegevens'

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
  },
  {
    path: "/Onderzoeken",
    element: <Onderzoeken />,
  },
  {
    path: "/Onderzoek",
    element: <GedetaileerdOnderzoek />,
  },
  {
    path: "/Gegevens",
    element: <Gegevens />,
  }

];

export default AppRoutes;
