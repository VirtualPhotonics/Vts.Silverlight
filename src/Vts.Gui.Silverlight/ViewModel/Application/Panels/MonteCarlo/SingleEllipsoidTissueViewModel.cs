﻿//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using Vts.MonteCarlo;
//using Vts.MonteCarlo.Extensions;
//using Vts.MonteCarlo.Tissues;

//namespace Vts.Gui.Silverlight.ViewModel
//{
//    public class SingleEllipsoidTissueViewModel : BindableObject
//    {
//        private SingleEllipsoidTissueInput _input;

//        private ObservableCollection<LayerRegionViewModel> _layerRegionsVM;

//        private EllipsoidRegionViewModel _ellipsoidRegionVM;

//        public SingleEllipsoidTissueViewModel(SingleEllipsoidTissueInput input)
//        {
//            _input = input;

//            // todo: this should be in validation with a warning...
//            var nLayer= _input.LayerRegions.Where(region => region.ContainsPosition(_input.EllipsoidRegion.Center)).First().RegionOP .N;
//            _input.EllipsoidRegion.RegionOP.N = nLayer;

//            _ellipsoidRegionVM = new EllipsoidRegionViewModel((EllipsoidRegion)input.EllipsoidRegion, "Ellipsoid Region");

//            _layerRegionsVM = new ObservableCollection<LayerRegionViewModel>(
//                _input.LayerRegions.Select((r, i) => new LayerRegionViewModel(
//                    (LayerRegion)r, 
//                    "Layer " + i + (r.IsAir() ? " (Air)" : " (Tissue)"))));
//        }

//        public SingleEllipsoidTissueViewModel()
//            : this(new SingleEllipsoidTissueInput())
//        {
//        }

//        public EllipsoidRegionViewModel EllipsoidRegionVM
//        {
//            get { return _ellipsoidRegionVM; }
//            set
//            {
//                _ellipsoidRegionVM = value;
//                OnPropertyChanged("EllipsoidRegionVM");
//            }
//        }

//        public ObservableCollection<LayerRegionViewModel> LayerRegionsVM
//        {
//            get { return _layerRegionsVM; }
//            set
//            {
//                _layerRegionsVM = value;
//                OnPropertyChanged("LayerRegionsVM");
//            }
//        }

//        public SingleEllipsoidTissueInput GetSingleEllipsoidTissueInput()
//        {
//            return _input;
//        }
//    }
//}
