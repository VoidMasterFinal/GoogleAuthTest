import Home from './Pages/Home'
import GoogleLogin from './Pages/GoogleLogin'
import UserHome from './Pages/UserHome'
import Register from './Pages/Register'
import Onderzoeken from './Pages/Onderzoeken'
import GedetaileerdOnderzoek from './Pages/GedetaileerdOnderzoek'
import Gegevens from './Pages/Gegevens'
import BedrijfsHome from './Pages/BedrijfsHome'
import OnderzoekOpstellen from './Pages/OnderzoekOpstellen'
import EigenOnderzoeken from './Pages/EigenOnderzoeken'
import BeheerdersHome from './Pages/BeheerdersHome'
import GedetaileerdOnderzoekMOD from './Pages/GedetaileerdOnderzoekMOD'

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
  },
  {
    path: "/BedrijfsHome",
    element: <BedrijfsHome />,
  },
  {
    path: "/OnderzoekOpstellen",
    element: <OnderzoekOpstellen />
  },
  {
    path: "/EigenOnderzoeken",
    element: <EigenOnderzoeken />
  },
  {
    path: "/BeheerdersHome",
    element: <BeheerdersHome />
  },
  {
    path: "/OnderzoekMOD",
    element: <GedetaileerdOnderzoekMOD />
  }
];

export default AppRoutes;
